using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF_9_4_Binary_De_Serialization
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private Deck randomDeck(int Number)
        {
            Deck myDeck = new Deck(new Card[] { });
            for (int i = 0; i < Number; i++)
            {
                myDeck.Add(new Card(
                    (Suits)random.Next(4),
                    (Values)random.Next(1, 13)));
            }
            return myDeck;
        }
        private void DealCards(Deck deckToDeal, string Title)
        {
            Console.WriteLine("Title");
            while (deckToDeal.Count > 0)
            {
                Card nextCard = deckToDeal.Deal(0);
                Console.WriteLine(nextCard.Name);
            }
            Console.WriteLine("--------------------------------");
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            Deck deckToWrite = randomDeck(5);
            using (Stream output = File.Create("Zestaw1.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, deckToWrite);
            }
            DealCards(deckToWrite, "To, co zapisałem do pliku");
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            Deck deckFromFile;
            using (Stream input = File.OpenRead("Zestaw1.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                deckFromFile = (Deck)bf.Deserialize(input);
                DealCards(deckFromFile, "To co z pliku odczytałem.");
            }

        }

        private void btnSerializeMany_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create("Zestaw2.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                for (int i = 0; i <= 5; i++)
                {
                    Deck deckToWrite = randomDeck(10);
                    bf.Serialize(output, deckToWrite);
                    DealCards(deckToWrite, $"Zestaw numer {i} zapisany.");
                }
            }
        }

        private void btnDeserializeMany_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Zestaw2.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                for (int i = 0; i <= 5; i++)
                {
                    Deck deckToRead = (Deck)bf.Deserialize(input);
                    DealCards(deckToRead, $"Zestaw numer {i} odczytany.");
                }
            }
        }

        private void btn3ofClubs_Click(object sender, EventArgs e)
        {
            Card ThreeOfClubs = new Card(Suits.Clubs, Values.Three);
            using (Stream output = File.Create("karta1.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, ThreeOfClubs);
            }
        }

        private void btn6ofHearts_Click(object sender, EventArgs e)
        {
            Card SixOfHearts = new Card(Suits.Hearts, Values.Six);
            using (Stream output = File.Create("karta2.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, SixOfHearts);
            }
        }

        private void btnReadBytes_Click(object sender, EventArgs e)
        {
            byte[] firstFile = File.ReadAllBytes("karta1.dat");
            byte[] secondFile = File.ReadAllBytes("karta2.dat");
            for (int i = 0; i < firstFile.Length; i++)
            {
                if (firstFile[i] != secondFile[i])
                {
                    Console.WriteLine($"Bajt numer {i}: {firstFile[i]} i {secondFile[i]}");
                }
            }
            firstFile[347] = (byte)Suits.Spades;
            firstFile[412] = (byte)Values.King;
            File.Delete("karta3.dat");
            File.WriteAllBytes("karta3.dat", firstFile);
            Console.WriteLine("Zapisano króla pik w pliku karta3.dat");

            using (Stream input = File.OpenRead("karta3.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Card cardFromFile = (Card)bf.Deserialize(input);
                Console.WriteLine(cardFromFile);
            }
        }

        // totalnie niezrefaktoryzowane ćwiczenie
        private void btnHex_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
                DialogResult saveAs = saveFileDialog1.ShowDialog();
                if (saveAs == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding("Windows-1250")))
                    using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                    {
                        int position = 0;
                        while (!reader.EndOfStream)
                        {
                            char[] buffer = new char[16];
                            int charactersRead = reader.ReadBlock(buffer, 0, 16);
                            writer.Write($"{String.Format("{0:x4}", position)}: ");
                            position += charactersRead;
                            for (int i = 0; i < 16; i++)
                            {
                                if (i < charactersRead)
                                {
                                    string hex = String.Format("{0:x2}", (byte)buffer[i]);
                                    writer.Write(hex + " ");
                                }
                                else
                                    writer.Write("    ");
                                if (i == 7) { writer.Write("-- "); }
                                if (buffer[i] < 32 || buffer[i] > 380) { buffer[i] = '-'; }
                            }
                            string bufferContents = new string(buffer);
                            writer.WriteLine("    " + bufferContents.Substring(0, charactersRead));
                        }

                    }

                }

            }

        }
    }
}
