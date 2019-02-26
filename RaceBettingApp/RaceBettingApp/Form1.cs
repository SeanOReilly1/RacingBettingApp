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
    }
}
 