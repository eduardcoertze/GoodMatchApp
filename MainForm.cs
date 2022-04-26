using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.IO;
using System.Globalization;

namespace GoodMatchApp
{

    public partial class MainForm : Form
    {
        //Global varible declarations
        public static int counter = 0;
        public static List<int> numTotal = new List<int>();
        public static String st = "";
        public static String test = "";
        public static List<String> testList = new List<String>();
        public static StringBuilder build2 = new StringBuilder();
        public static StringBuilder build1 = new StringBuilder();
        public static List<Player> totalPlayerList = new List<Player>();
        public static List<PlayerPair> csvResultOutput = new List<PlayerPair>();
        public static List<String> csvStringResultOutput = new List<String>();

        public OpenFileDialog ofd = new OpenFileDialog();

        public MainForm()
        {
            InitializeComponent();
        }

        //MainForm on load method
        private void MainForm_Load(object sender, EventArgs e)
        {
            btnViewGroupPercentage.Visible = false;
        }

        //btnViewMatchPercentage button which returns a MessageBox displaying
        //the name's of the two inputted player and their match %
        private void btnViewMatchPercentage_Click(object sender, EventArgs e)
        {
            //clearing of local variables
            String playerOneFirstName = "";
            String playerTwoFirstName = "";
            String combinestring = "";

            //storing the user input from textbox to a String variable 
            playerOneFirstName = txtPlayerOne.Text.ToLower();
            playerTwoFirstName = txtPlayerTwo.Text.ToLower();

            //combining the two player names with "matches"
            combinestring = (playerOneFirstName + "matches" + playerTwoFirstName);

            //if statment to check if textbox is null or empty
            if (String.IsNullOrEmpty(txtPlayerOne.Text) || String.IsNullOrEmpty(txtPlayerTwo.Text))
            {
                MessageBox.Show("Player name cannot be Null or Empty");
                return;
            }

            //if statment which uses the Regex class to ensure only user input which is
            //alphabetic is accepted
            if (Regex.IsMatch(combinestring, @"^[a-zA-Z]+$"))
            {
                MainForm m = new MainForm();

                //use of the countChars method to determine how
                //many times each character occurred in the combinestring String
                m.countChars(combinestring);

                StringBuilder b1 = new StringBuilder();

                //foreach statment which appends each int item in list numTotal
                //to the StringBuilder object b1
                foreach (int item in numTotal)
                {
                    b1.Append(item);
                }

                st = b1.ToString();

                //while loop which adds the left most and right most number in st
                //string varible until only 2 digits left in the final string
                while (st.Length > 2)
                {
                    int x = 0;
                    build1.Clear();
                    build2.Clear();
                    testList.Clear();
                    test = "";

                    while (st.Length > 1)
                    {
                        x = 0;
                        build1.Clear();
                        build2.Clear();
                        test = "";

                        //adding the left most and right most number
                        x = int.Parse(st[0].ToString()) + int.Parse(st[^1].ToString());

                        build1.Append(x);

                        test = build1.ToString();

                        testList.Add(test);

                        //removing the left most and right most number
                        st = st.Substring(1, st.Length - 2);
                    }
                    testList.Add(st);

                    st = "";

                    //setting string st to the two digit number
                    foreach (String item in testList)
                    {
                        build2.Append(item);
                        st = build2.ToString();
                    }
                    st = build2.ToString();
                }

                //if statment which checks if the match % is more than 80% and
                //outputting a messagebox based on this check
                if (int.Parse(st) > 80)
                {
                    MessageBox.Show(playerOneFirstName + " matches " + playerTwoFirstName + " " + st + "%, good match");
                }
                else
                {
                    MessageBox.Show(playerOneFirstName + " matches " + playerTwoFirstName + " " + st + "%");
                }

                //clearing of of local variables
                numTotal.Clear();
                st = "";
                build1.Clear();
                build2.Clear();
                test = "";
                txtPlayerOne.Clear();
                txtPlayerTwo.Clear();

            }
            else
            {
                //clearing of textboxes
                txtPlayerOne.Clear();
                txtPlayerTwo.Clear();

                //messagebox which is displayed to the user when an non-alphabetic input is 
                //inputted into the player name textboxes
                MessageBox.Show("Please re-input your player names with ONLY ALPHABETIC characters");
            }
        }

        //method which receives the names of two players and returns a PlayerPair object
        public static PlayerPair matchPlayerOutput(string playerNameOne, string playerNameTwo)
        {
            //clearing of local variables
            String combinestring = "";
            numTotal.Clear();
            st = "";
            build1.Clear();
            build2.Clear();
            test = "";

            //combining the two player names with "matches"
            combinestring = (playerNameOne + "matches" + playerNameTwo);

            MainForm m = new MainForm();

            //use of the countChars method to determine how
            //many times each character occurred in the combinestring String
            m.countChars(combinestring);

            StringBuilder b1 = new StringBuilder();

            //foreach statment which appends each int item in list numTotal
            //to the StringBuilder object b1
            foreach (int item in numTotal)
            {
                b1.Append(item);
            }

            st = b1.ToString();

            //while loop which adds the left most and right most number in st
            //string varible until only 2 digits left in the final string
            while (st.Length > 2)
            {
                int x = 0;
                build1.Clear();
                build2.Clear();
                testList.Clear();
                test = "";

                while (st.Length > 1)
                {
                    x = 0;
                    build1.Clear();
                    build2.Clear();
                    test = "";

                    //adding the left most and right most number
                    x = int.Parse(st[0].ToString()) + int.Parse(st[^1].ToString());

                    build1.Append(x);

                    test = build1.ToString();

                    testList.Add(test);

                    //removing the left most and right most number
                    st = st.Substring(1, st.Length - 2);
                }
                testList.Add(st);

                st = "";

                //setting string st to the two digit number
                foreach (String item in testList)
                {
                    build2.Append(item);
                    st = build2.ToString();
                }
                st = build2.ToString();
            }

            //instantiation and initialization of the pair PlayerPair object
            PlayerPair pair = new PlayerPair(playerNameOne, playerNameTwo, Int32.Parse(st));

            return pair;



        }

        //countChars method which determines how many times each charater
        //occurs in a string 
        public void countChars(String str)
        {
            char[] strArr;
            while (str.Length != 0)
            {
                strArr = str.ToCharArray();
                char ch = strArr[0];
                int count = 1;
                for (int i = 1; i < strArr.Length; i++)
                {
                    if (ch == strArr[i])
                    {
                        count++;
                    }
                }

                numTotal.Add(count);

                // replace all occurrence of the character 
                // which is already iterated and counted
                str = str.Replace("" + ch, "");
            }

        }

        //button which displays a OpenFileDialog and receives the users .txt file path 
        private void btnSelectCSVFile_Click(object sender, EventArgs e)
        {
            //ensures the user can only input a .txt CSV file
            ofd.Filter = "txt files (*.txt)|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtCSVFileName.Text = ofd.FileName;
            }

            btnViewGroupPercentage.Visible = true;
        }

        //method which writes the player match % of each players on the CSV file
        //based on gender pairs
        private void btnViewGroupPercentage_Click(object sender, EventArgs e)
        {
            //empty output.txt file
            File.WriteAllText("output.txt", String.Empty);

            String fileName = ofd.FileName;

            //String array which reads all lines within the CSV file
            String[] csvRawArray = System.IO.File.ReadAllLines(fileName);

            //forloop which loops through the csvRawArray array and assigns the
            //data to a Player object
            for (int i = 1; i < csvRawArray.Length; i++)
            {
                String[] rowData = csvRawArray[i].Split(',');

                Player p1 = new Player();

                p1.name = rowData[0];
                String dataNoSpace = removeSpace(rowData[1]);
                char character = char.Parse(dataNoSpace);
                p1.gender = character;

                //adding the player object to the totalPlayerList
                //Player List
                totalPlayerList.Add(p1);
            }

            //local Player Lists for male and female players
            List<Player> maleList = new List<Player>();
            List<Player> femaleList = new List<Player>();

            //foreach loop which assigns the Players to either the
            //maleList or femaleList based on gender property
            foreach (Player item in totalPlayerList)
            {

                if (item.gender == 'm')
                {

                    maleList.Add(item);
                }
                else
                {
                    femaleList.Add(item);
                }
            }

            //sorting the the maleList and femaleList to remove any duplicates within
            //the same gender List
            List<Player> sortedMaleList = maleList.GroupBy(p => p.name).Select(g => g.First()).ToList();

            List<Player> sortedFemaleList = femaleList.GroupBy(p => p.name).Select(g => g.First()).ToList();

            //for loop which uses the matchPlayerOutput method to calculate the match percentage
            //of each player pair in the two gender Lists
            for (int n = 0; n < sortedMaleList.Count; n++)
            {
                Player n1 = sortedMaleList.ElementAt(n);
                for (int m = 0; m < sortedFemaleList.Count; m++)
                {
                    Player m1 = sortedFemaleList.ElementAt(m);

                    csvResultOutput.Add(matchPlayerOutput(n1.name, m1.name));


                }

            }


            maleList.Clear();
            femaleList.Clear();

            //Linq to order the matched pairs based on match percentage
            List<PlayerPair> SortedList = csvResultOutput.OrderByDescending(o => o.playerMatch).ToList();

            foreach (PlayerPair item in SortedList)
            {
                //if statment which checks if the match % is more than 80% and
                //adding the output to the String List csvStringResultOutput
                if (item.playerMatch > 80)
                {
                    String output = item.playerOneName + " matches " + item.playerTwoName + " " + item.playerMatch + "%, good match";
                    csvStringResultOutput.Add(output);
                }
                else
                {
                    String output = item.playerOneName + " matches " + item.playerTwoName + " " + item.playerMatch + "%";
                    csvStringResultOutput.Add(output);
                }
            }
            System.IO.File.WriteAllLines("output.txt", csvStringResultOutput);

            //clearing varibles
            SortedList.Clear();
            sortedFemaleList.Clear();
            sortedMaleList.Clear();
            maleList.Clear();
            femaleList.Clear();
            totalPlayerList.Clear();
            csvStringResultOutput.Clear();
            csvResultOutput.Clear();

        }

        //method to remove blank spaces from a string
        static String removeSpace(String str)
        {
            str = str.Replace(" ", "");
            return str;
        }
    }
}

