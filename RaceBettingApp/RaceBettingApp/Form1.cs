using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace RaceBettingApp
{
    public partial class Form1 : Form
    {
        string File = @"\\sec.local\Data\Homes\SO0393\My Documents\AdvancedProgramming\RaceBettingApp\New.txt";
        
        List<Races> ListOfRaces;
        ListOfRaces HardCodedRaces;
        // private ListOfRaces RaceList = new ListOfRaces();

        public Form1()
        {
            
            InitializeComponent();
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
          
               // using (FileStream ss = System.IO.File.OpenWrite(File))
               // {
                    using (StreamWriter sw = new StreamWriter(File,append:true))
                    {

                      /*  try
                        {

                        ListOfRaces.Add(new Races
                            {
                                RaceName = txtRaceCourse.Text, Date = DateTime.Parse(dtpDate.Text), Length = decimal.Parse(txtLenght.Text),
                                Result = chkWinner.Checked});
                          
                        }
                        catch (Exception ex)
                        {
                        MessageBox.Show("Nothing in file");
                        }*/

                        //foreach (var race in ListOfRaces)
                        //{

                     
                        sw.WriteLine(string.Format("{0}, {1}, {2}, {3}", txtRaceCourse.Text, DateTime.Parse(dtpDate.Text), txtLenght.Text, chkWinner.Checked));

                   // }

                    MessageBox.Show($"Bet added to location : {File} Successfully");



                    

                }
      
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ListOfRaces = new List<Races>();
            

            
            // try
            //{


            using (FileStream fs = System.IO.File.OpenRead(File))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                    List<string> lines = System.IO.File.ReadAllLines(File).ToList();

                        foreach (var line in lines)
                        {
                        Races race = new Races();
                            string[] entries = line.Split(',');
                            race.RaceName = entries[0];
                            race.Date = DateTime.Parse(entries[1]);
                            race.Length = decimal.Parse(entries[2]);
                            race.Result = bool.Parse(entries[3]);
                        ListOfRaces.Add(race);


                        }

                        foreach (var race in ListOfRaces)
                        {
                        dgvHorseBets.DataSource = (from races in ListOfRaces
                                                    select races).ToList();

                        
                    }

                    //RaceList.Clear();






                    }
                }
            
           
        }

        private void btnSortDate_Click(object sender, EventArgs e)
        {

            var reportSet = from result in ListOfRaces
                            orderby result.Date
                            select result;
         
            dgvHorseBets.DataSource = reportSet.ToList();



        }

        private void btnAmmountWon_Click(object sender, EventArgs e)
        {
            rtbRead.Clear();
            var wonCount = ListOfRaces.Count(r => r.Result == true);
            decimal winning = wonCount/ListOfRaces.Count() *100m;
            decimal percentage = winning * 100m;

            rtbRead.AppendText($"The total number of races tipped is {ListOfRaces.Count()}." + Environment.NewLine);
            rtbRead.AppendText($"The total number of wins for races tipped is {wonCount}." + Environment.NewLine);
            rtbRead.AppendText($"Percentage success is {percentage} %." + Environment.NewLine);


        }

        private void btnPopularCourse_Click(object sender, EventArgs e)
        {
            rtbRead.Clear();
            var queryResult = ListOfRaces.
                                GroupBy(a => a.RaceName,
                                (keys, value) => new { Races = keys, allBets = value.Count() })
                                .OrderByDescending(b => b.allBets);



            var totalRaceTracks = queryResult.OrderBy(d => d.Races);
            var mostPopular = queryResult.First();
            var leastPopular = queryResult.Last();
            // dgvHorseBets.DataSource = RaceList.GroupBy(race => race.RaceName)
            //        .OrderByDescending(race => race.Count()).ToList();

            //rtbRead.AppendText($"The tracks in this system are " + totalRaceTracks + Environment.NewLine);
            rtbRead.AppendText($"Race course with most bets placed is " + mostPopular.Races + Environment.NewLine);
            rtbRead.AppendText($"Race course with least bets placed is " + leastPopular.Races + Environment.NewLine);
            



            dgvHorseBets.DataSource = queryResult.ToList();
        }

        private void btnViewAllTracks_Click(object sender, EventArgs e)
        {
            var reportSet = from result in ListOfRaces
            orderby result.RaceName
            select result;

           // rtbRead.AppendText($"Race courses " + reportSet + Environment.NewLine);
            dgvHorseBets.DataSource = reportSet.ToList();
        }

        private void btnGetOldData_Click(object sender, EventArgs e)
        {
            string message = "This has overriden races with hard coded data";
            MessageBox.Show(message);

            HardCodedRaces = new ListOfRaces()
            {
                new Races { RaceName = "Aintree", Date = new DateTime(2017, 05, 12), Length = 11.58m, Result = true },
                new Races { RaceName = "Punchestown", Date = new DateTime(2016, 12, 22),Length = 122.52m, Result = true },
                 new Races { RaceName =  "Sandown", Date = new DateTime (2016, 11, 17), Length = 20.00m, Result = false },
                 new Races { RaceName = "Ayr", Date = new DateTime(2016, 11, 03), Length = 25.00m, Result = false },
                 new Races { RaceName = "Fairyhouse", Date = new DateTime (2016, 12, 02), Length = 65.75m, Result =  true },
                 new Races { RaceName = "Ayr", Date =  new DateTime(2017,03, 11), Length = 12.05m, Result = true },
                 new Races { RaceName = "Doncaster", Date = new DateTime(2017, 12, 02), Length = 10.00m, Result = false },
                 new Races { RaceName = "Towcester", Date = new DateTime(2016, 03, 12), Length =  50.00m, Result = false },
                 new Races { RaceName = "Goodwood" , Date = new DateTime(2017, 10, 07), Length =  525.74m, Result =  true },
                 new Races { RaceName = "Kelso", Date = new DateTime(2016, 09, 13), Length = 43.21m, Result = true },
                 new Races { RaceName = "Punchestown", Date = new DateTime(2017, 07, 05), Length = 35.00m, Result = false },
                 new Races { RaceName = "Ascot", Date = new DateTime(2016, 02, 04), Length = 23.65m, Result = true },
                 new Races { RaceName = "Kelso",  Date = new DateTime(2017, 08, 02), Length = 30.00m, Result = false },
                 new Races { RaceName = "Towcester", Date = new DateTime(2017, 05, 01), Length = 104.33m, Result = true },
                 new Races { RaceName =  "Ascot",  Date=  new DateTime(2017, 06, 21), Length = 25.00m, Result =  false },
                 new Races { RaceName = "Bangor", Date = new DateTime(2016, 12, 22), Length = 30.00m, Result =  false },
                 new Races { RaceName = "Ayr", Date = new DateTime(2017, 05, 22), Length = 11.50m, Result = true },
                 new Races { RaceName = "Ascot", Date = new DateTime(2017, 06, 23), Length = 30.00m, Result = false },
                 new Races { RaceName = "Ascot", Date = new  DateTime(2017, 06, 23), Length = 374.27m, Result = true },
                 new Races { RaceName = "Goodwood", Date = new DateTime(2016, 10, 05), Length = 34.12m, Result = true },
                 new Races { RaceName = "Dundalk", Date = new DateTime(2016, 11, 09), Length = 20.00m, Result = false },
                 new Races { RaceName = "Haydock", Date = new DateTime(2016, 11, 12), Length = 87.00m, Result = true },
                 new Races { RaceName = "Perth", Date = new DateTime(2017, 01, 20), Length = 15.00m, Result = false },
                 new Races { RaceName = "York", Date = new DateTime(2017, 11, 11), Length = 101.25m, Result = true },
                 new Races { RaceName = "Punchestown", Date = new DateTime(2016, 12, 22), Length = 11.50m, Result = true },
                 new Races { RaceName = "Chester", Date = new DateTime(2016, 08, 14), Length =  10.00m, Result =  false },
                 new Races { RaceName = "Kelso", Date = new DateTime(2016, 09, 18),  Length = 10.00m, Result =  false },
                 new Races { RaceName = "Kilbeggan",  Date = new DateTime(2017, 03, 03), Length = 20.00m, Result = false },
                 new Races { RaceName = "Fairyhouse", Date = new DateTime(2017, 03, 11), Length = 55.50m, Result = true },
                 new Races { RaceName = "Punchestown", Date = new DateTime(2016, 11, 15), Length =  10.00m, Result = false },
                 new Races { RaceName = "Towcester", Date = new DateTime(2016, 05, 08), Length = 16.55m, Result = true },
                 new Races { RaceName = "Punchestown", Date = new DateTime(2016, 05, 23), Length = 13.71m, Result = true },
                 new Races { RaceName = "Cork", Date = new DateTime(2016, 11, 30), Length = 20.00m, Result = false },
                 new Races { RaceName = "Punchestown", Date = new DateTime(2016, 04, 25), Length = 13.45m, Result = true },
                 new Races { RaceName = "Bangor", Date = new DateTime(2016, 01, 23), Length = 10.00m, Result = false },
                 new Races { RaceName = "Sandown", Date = new DateTime(2017, 08, 07), Length = 25.00m, Result = false }
            };

            using (StreamWriter br = new StreamWriter(File))
            {

                foreach (var race in HardCodedRaces)
                {
                    br.WriteLine($"{race.RaceName},{race.Date.ToShortDateString()},{race.Length},{race.Result}");

                }

            }
        }
        
    }
}
 