using System;
using System.Runtime.InteropServices.Marshalling;
using DailyDiary;
using DBConnect;
using MainConsole;
using Microsoft.EntityFrameworkCore;

namespace MainConsole;

public class DiaryLogic
{
    // Diary siteDiary = new MajorConstructionDiary(1, DateTime.Now, "Manchester", "Excavation", DateTime.Now, DateTime.Now);
    //Console.WriteLine(siteDiary.toString());
    DiaryEntry diary = null;
    SiteDiaryContext createDiaryEntry = new SiteDiaryContext();
    // DiaryOptions options = new DiaryOptions();
    int idCount = 0;

    public void SelectMenu ()
        {
            bool flag = true;
            do 
            {
                string response = null;

                Console.WriteLine("------------------------");
                Console.WriteLine("     Site Diary");
                Console.WriteLine("------------------------");
                Console.WriteLine();
                Console.WriteLine("Please select from the below options:");
                Console.WriteLine("[1] Site Diaries");
                Console.WriteLine("[2] Issues & Delays");
                Console.WriteLine("[q] Quit");


                response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        SelectDiaryOption();
                        break;
                    case "q":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("No value");
                        break;
                }
            } while (flag);

        Console.WriteLine(diary.ToString());

    }

        public void SelectDiaryOption ()
        {
            bool flag = true;
            do 
            {
                string response = null;

                Console.WriteLine("------------------------");
                Console.WriteLine("     Site Diary");
                Console.WriteLine("------------------------");
                Console.WriteLine();
                Console.WriteLine("Please select from the below options:");
                Console.WriteLine("[1] Major Construction Activities");
                Console.WriteLine("[2] Contractors on Site");
                Console.WriteLine("[3] Discussions/Conversations");
                Console.WriteLine("[4] Deliveries");
                Console.WriteLine("[5] Plants");
                Console.WriteLine("[q] Back");


                response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        //diary = DiaryFactory.Create(DiaryMethod.MajorConstructionDiary, idCount);
                        diary = DiaryOptions.MajorDiaryOption();

                        createDiaryEntry.Add(diary);
                        int success = createDiaryEntry.SaveChanges();
                        try 
                            {   
                                if(success == 1) {
                                    Console.WriteLine("Success");
                                } else {
                                    Console.WriteLine("Not successful");
                                }

                            } catch (DbUpdateException ex)
                            {
                                Console.WriteLine($"Database update failed: {ex.InnerException?.Message}");
                            }
                            catch (InvalidOperationException ex)
                            {
                                Console.WriteLine($"Invalid operation: {ex.Message}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"An error occurred: {ex.Message}");
                            }

                        break;
                    case "2":
                        //diary = DiaryFactory.Create(DiaryMethod.ContractorsOnSite, idCount);
                        break;
                    case "3":
                        //diary = DiaryFactory.Create(DiaryMethod.Discussions, idCount);
                        break;
                    case "4":
                        //diary = DiaryFactory.Create(DiaryMethod.Deliveries, idCount);
                        break;
                    case "5":
                        //diary = DiaryFactory.Create(DiaryMethod.Plant, idCount);
                        break;
                    case "q":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("No value");
                        break;
                }
            } while (flag);



        
        Console.WriteLine(diary.ToString());

    }
}

