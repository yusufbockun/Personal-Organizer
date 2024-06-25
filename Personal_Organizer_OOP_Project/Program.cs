using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Organizer_OOP_Project
{
    public static class MainVariables
    {
        //MENU VARIABLES
        public static bool registerScreenIsOpen { get; set; }
        //menü applikasyonundan çıkar
        public static bool menuQuit { get; set; }

        //bütün herşeyi kapatır
        public static bool all_Quit { get; set; }
        //

        //USERS VARIABLE
        public static List<List<string>> personalsInfo = new List<List<string>>();
        public static List<List<string>> phonebooklist = new List<List<string>>();
        public static List<List<string>> noteslist = new List<List<string>>();
        public static List<List<string>> emaillist = new List<List<string>>();
        public static List<List<string>> reminderlist = new List<List<string>>();
        public static List<List<string>> salarylist = new List<List<string>>();
        public static string user_type { get; set; }
        public static string user_name { get; set; }
        public static string email { get; set; }   
        public static string reminder { get; set; }
    //index of personals: 0=user_type, 1=name,2=surname,3:userName,4:phonebook,5:adress,6:e-Mail,7:password,9:photo location

    public static void readCSV(string filename)
        {
            try
            {
                using (var streamReader = new StreamReader(new FileStream(filename, FileMode.Open)))
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        Delimiter = ",",
                        HasHeaderRecord = false
                    };

                    using (var csv = new CsvReader(streamReader, config))
                    {
                        var records = new List<List<string>>();
                        while (csv.Read())
                        {
                            var record = new List<string>();
                            for (int i = 0; csv.TryGetField<string>(i, out var field); i++)
                            {
                                record.Add(field);
                            }
                            records.Add(record);
                        }
                        MainVariables.personalsInfo = records;
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Dosya bulunamadı: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
        }
        public static void writeCSV(string filename)
        {
            try
            {
                // Dosyayı sıfırlayarak tüm kayıtları yeniden yaz
                using (var streamWriter = new StreamWriter(new FileStream(filename, FileMode.Create, FileAccess.Write)))
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        Delimiter = ",",
                        HasHeaderRecord = false
                    };

                    using (var csv = new CsvWriter(streamWriter, config))
                    {
                        foreach (var record in MainVariables.personalsInfo)
                        {
                            foreach (var field in record)
                            {
                                csv.WriteField(field);
                            }
                            csv.NextRecord();
                        }
                    }
                }
                Console.WriteLine($"Veriler başarıyla {filename} dosyasına yazıldı.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }






    }
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new MainForm());


            //applikasyon
           while(!MainVariables.all_Quit)
            {
                MainVariables.readCSV("personalsInfo.csv");
                //Menu Döngüsü
                while (!MainVariables.menuQuit)
                {
                    if (MainVariables.registerScreenIsOpen) Application.Run(new RegisterScreen());
                    else Application.Run(new LoginScreen());
                }
                //tamamen kapanma testi
                if (!MainVariables.all_Quit)
                {
                    
                    Application.Run(new MainForm());

                }


            }



        }

    }
}
