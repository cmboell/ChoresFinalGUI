using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoresFinalGUI
{
    public partial class Form1 : Form
    {
        //variables
        private Chore[] choreList = new Chore[1];

        public Form1()
        {
            InitializeComponent();
        }

        //method to write to a file
        private void write(Chore chore)
        {
            StreamWriter sw = new StreamWriter("Chores.txt"); //writes to file
            sw.WriteLine(choreList.Length + 1); //updates array size
            sw.WriteLine(chore.Name);
            sw.WriteLine(chore.HoursToComplete);
            sw.WriteLine(chore.PriorityLevel);

            for (int x = 0; x < choreList.Length; x++)
            { //for loop to cycle through array
                sw.WriteLine(choreList[x].Name);
                sw.WriteLine(choreList[x].HoursToComplete);
                sw.WriteLine(choreList[x].PriorityLevel);
            }
            sw.Close(); //closes and saves to file
        }

        private void Read() { //method to read file
            StreamReader sr = new StreamReader("Chores.txt"); // creates reader

            choreList = new Chore[Convert.ToInt32(sr.ReadLine())];//reads first line of file after converting to int

            //loop through text file
            for (int x = 0; x < choreList.Length; x++) {
                choreList[x] = new Chore();
                    choreList[x].Name = sr.ReadLine();
                    choreList[x].HoursToComplete = sr.ReadLine();
                    choreList[x].PriorityLevel = sr.ReadLine();
            }
            sr.Close(); //closes reader
        }

        private void Display() {
            ListOfChores.Items.Clear(); //clears out the list

            for (int x = 0; x < choreList.Length; x++) {
                //adds info to the list 
                ListOfChores.Items.Add(choreList[x].toString());
            }
        }

        private void ClearForm() { //clears text boxes after press enter
            ChoreName.Text = String.Empty;
            htcTxt.Text = String.Empty;
            pTxt.Text = String.Empty;
        }
        private void enterChore_Click(object sender, EventArgs e)
        {
            //gets info from text boxes and gives variables values
            Chore chore = new Chore();
            chore.Name = ChoreName.Text;
            chore.HoursToComplete = htcTxt.Text;
            chore.PriorityLevel = pTxt.Text;
            write(chore);
            Read();
            BubbleSort();
            Display();
            ClearForm();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void htcTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {  //loads the info into the list area

            Read();
            BubbleSort();
            Display();
        }

        /*private void SortButton_Click(object sender, EventArgs e)
        {
            BubbleSort();
            Display();
        }*/

        private void BubbleSort() {
            Chore temp;
            bool swap;

           do //do while loop to sort
            {
                swap = false;

                for (int x = 0; x < (choreList.Length - 1); x++) {
                    if (choreList[x].Name.CompareTo(choreList[x + 1].Name) > 0) {
                        temp = choreList[x];
                        choreList[x] = choreList[x + 1];
                        choreList[x + 1] = temp;
                        swap = true;
                    }
                }
            } while (swap == true); 
        }

        private void hourButton_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*String name;
            double hours;
            char priority;
            PriorityQueue a = new PriorityQueue();
            for (int x = 0; x < (choreList.Length - 1); x++)
            {

                name = choreList[x].Name;
                hours = Convert.ToDouble(choreList[x].HoursToComplete);
                priority = Convert.ToChar(choreList[x].PriorityLevel);
                a.enqueue(name, hours, priority);

            }

            ListOfChores.Items.Add(a.printQueue().ToString());
            Display();*/
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            ListOfChores.Items.Remove(ListOfChores.SelectedItem);
        }
    }
}
