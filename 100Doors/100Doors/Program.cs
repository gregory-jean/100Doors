using System;

namespace _100Doors
{
    class Program
    {
        /// <summary>
        /// 
        /// Scenario:
        /// There are 100 doors in a row that are all initially closed.
        /// You make 100 passes by the doors.r
        /// The first time through, visit every door and  toggle the door  (if the door is closed, open it;   if it is open,  close it).
        /// The second time, only visit every 2nd door(door #2, #4, #6, ...),   and toggle it.
        /// The third time, visit every 3rd door   (door #3, #6, #9, ...), etc,   until you only visit the 100th door.
        /// 
        /// Task:
        /// Answer the question:   what state are the doors in after the last pass?   Which are open, which are closed?
        /// 
        /// </summary>


        static void Main(string[] args)
        {
            //create array of doors
            Door[] doors = new Door[100];
            
            //fill doors array and set door status 
            for (int i = 0; i < doors.Length; i++)
            {
                //create door
                doors[i] = new Door();

                //set door number, starting at 1 instead of 0
                doors[i].Number = i + 1;

                //set door status and message
                doors[i].Status = true;
                doors[i].Message = "Closed";

                //update message if door is shut
                if (doors[i].Status == false)
                {
                    doors[i].Message = "Open";
                }
                //Console.WriteLine("Door Number " + doors[i].Number + " is " + doors[i].Message);
            }

            int passNumber = 1;
            
            //Start Passes for opening and closing doors
            for (int i = 0; i < doors.Length; i++)
            {
                Console.WriteLine("Select Enter to start pass " + passNumber);
                Console.ReadLine();

                for (int j = 0; j < doors.Length; j++)
                {
                    if (doors[j].Number % passNumber == 0)
                    {
                        //reverse door status and update message related to door status
                        doors[j].Status = !doors[j].Status;
                        if (doors[j].Status == true)
                        {
                            doors[j].Message = "Closed on Pass " + passNumber;
                        }
                        else
                        {
                            doors[j].Message = "Opened on Pass "+ passNumber;
                        }
                    }
                    //print results
                    Console.WriteLine("Door Number " + doors[j].Number + " is " + doors[j].Message);

                }
                passNumber++;
            }
        }
    }
}
