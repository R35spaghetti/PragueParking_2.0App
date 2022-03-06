namespace Core
{
    class Program
    {
        public class VehicleHandling
        {
            private List<IVehicle> listOfVehicle = new List<IVehicle>();

            /// <summary>
            /// method to get the registration number from user
            /// </summary>
            /// <returns>regNum</returns>
            private string GetRegNum()
            {
                string regNum;
                bool validInput;
                do
                {
                    validInput = true;
                    regNum = "";
                    Console.WriteLine("Enter the registration number.");

                    while (regNum.Length < 1)
                    {
                        regNum = Console.ReadLine();
                    }
                } while (!validInput);
                return regNum;
            }

            /// <summary>
            /// Method to choose the type of the vehicle.
            /// </summary>
            /// <returns>VehicleType</returns>
            public IVehicle.VehicleType GetVehicleType()
            {
                while (true)
                {
                    Console.WriteLine("Is this a car(C) or an MC(M)?");
                    Console.WriteLine("Please answer with C or M.");
                    ConsoleKey input = Console.ReadKey().Key;

                    if (input == ConsoleKey.C)
                        return IVehicle.VehicleType.Car;

                    else if (input == ConsoleKey.M)
                        return IVehicle.VehicleType.MC;

                    else Console.WriteLine("Answer with C or M ");
                }
            }


            /// <summary>
            /// Method to look for a parking spot
            /// </summary>
            /// <param name="regnr"></param>
            /// <returns></returns>
            public int SearchForSpot(string regnr)
            {
                for (int i = 0; i < 200; i++)
                {
                    if (listOfVehicle[i].regNumber == regnr)
                        return i;
                }
                return -1;
            }


            /// <summary>
            /// Method to manually choose a parking spot 
            /// </summary>
            /// <returns></returns>
            public int GetSpotManually()
            {
                bool validInput = false;
                string input;
                int output;

                do
                {
                    validInput = true;
                    Console.WriteLine("Enter the parking spot, please.");
                    input = Console.ReadLine();

                    bool validInt = int.TryParse(input, out output);
                    if (!validInt)
                    {
                        Console.WriteLine("Enter only numbers please.");
                        validInput = false;
                    }
                    if (output < 1 || output > 100)
                    {
                        Console.WriteLine("Please enter numbers between 1 and 100");
                        validInput = false;
                    }
                } while (!validInput);
                return output - 1;
            }


            /// <summary>
            /// Method to search inside the parking spot
            /// </summary>
            public int SearchInsideSpot()
            {
                for (int i = 0; i < 200; i++)
                {
                    string regnr = GetRegNum();
                    if (listOfVehicle[i].regNumber == regnr)
                        return i;
                }
                return -1;
            }


            /// <summary>
            /// Method to add vehicles in the garage
            /// </summary>
            public void AddVehicle()
            {
                Console.WriteLine("Add a vehicle");
                Console.WriteLine();

                bool makeSpace = false;
                DateTime dateTime = DateTime.Now;

                string regnum = GetRegNum();
                IVehicle.VehicleType Type = GetVehicleType();

                if (Type == IVehicle.VehicleType.Car)
                {
                    for (int i = 0; i < 100; i++)
                    {
                        if (listOfVehicle[i].Type == IVehicle.VehicleType.Empty)
                        {
                            listOfVehicle.RemoveAt(i);
                            listOfVehicle.Insert(i, new IVehicle(Type, regnum, dateTime));
                            Console.WriteLine("Vehicle {0} has been parked at spot{1}",
                                listOfVehicle[i].regNumber,
                                i + 1);
                            makeSpace = true;
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 100; i++)
                    {
                        if (listOfVehicle[i + 100].Type == IVehicle.VehicleType.MC)
                        {
                            if (listOfVehicle[i + 100].Type == IVehicle.VehicleType.Empty)
                            {
                                listOfVehicle.RemoveAt(i + 100);
                                listOfVehicle.Insert(i + 100, new IVehicle(Type, regnum, dateTime));
                                Console.WriteLine("MC {0} is parked at spot {1}.\n" +
                                    "This spot is also holding MC {2}",
                                    listOfVehicle[i + 100].regNumber,
                                    i + 1,
                                    listOfVehicle[i].regNumber);
                                makeSpace = true;
                                break;
                            }
                        }
                    }
                    if (!makeSpace)
                    {
                        for (int i = 0; i < 100; i++)
                        {
                            if (listOfVehicle[i].Type == IVehicle.VehicleType.Empty)
                            {
                                listOfVehicle.RemoveAt(i);
                                listOfVehicle.Insert(i, new IVehicle(Type, regnum, dateTime));
                                Console.WriteLine("MC {0} is parked at spot {1}", listOfVehicle[i].regNumber, i + 1);
                                makeSpace = !true;
                                break;
                            }
                        }
                    }
                }

                if (!makeSpace)
                {
                    Console.WriteLine("Sorry, there is no spot for a {0} at this moment.", Type.ToString().ToLower());
                }
                else
                {
                    ReadWrite rw = new ReadWrite();
                    try
                    {
                        rw.WriteDataBase(listOfVehicle);
                    }
                    catch (FileNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                Console.ReadLine();
            }


            /// <summary>
            /// Method to delete a vehicle from a spot
            /// </summary>
            private void RemoveVehicle()
            {
                string regnumb = GetRegNum();
                int spotIndex = SearchForSpot(regnumb);

                if (spotIndex > 0 && spotIndex < 100)
                { 
                    if (listOfVehicle[spotIndex].Type == IVehicle.VehicleType.MC)
                    {
                        listOfVehicle[spotIndex] = listOfVehicle[spotIndex + 100];
                        listOfVehicle[spotIndex + 100] = new IVehicle(IVehicle.VehicleType.Empty,
                            "Empty", DateTime.UtcNow);
                    }
                    listOfVehicle[spotIndex] = new IVehicle(IVehicle.VehicleType.Empty,
                        "EMPTY", DateTime.UtcNow);
                }

                else if (spotIndex >= 100)
                {
                    listOfVehicle[spotIndex] = new IVehicle(IVehicle.VehicleType.Empty,
                        "EMPTY", DateTime.UtcNow);
                }
                else
                {
                    Console.WriteLine("That vehicle ({0}) is not parked here.", regnumb);
                }
                ReadWrite rw = new ReadWrite();
                try
                {
                    rw.WriteDataBase(listOfVehicle);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            /// <summary>
            /// Method to manually move vehicles inside the garage
            /// </summary>
            public void MoveVehicle()
            {
                string regnum = GetRegNum();
                int lookingForSpot = SearchForSpot(regnum);

                if (lookingForSpot < 0)
                {
                    Console.WriteLine("Vehicle {0} does not exist", regnum);

                }
                else
                {
                    int determindSpot = GetSpotManually();
                    if (listOfVehicle[lookingForSpot].Type == IVehicle.VehicleType.MC
                        && listOfVehicle[determindSpot].Type == IVehicle.VehicleType.MC)
                    {
                        IVehicle vehicl = listOfVehicle[determindSpot + 100];
                        listOfVehicle[determindSpot + 100] = listOfVehicle[lookingForSpot];
                        listOfVehicle[(lookingForSpot)] = vehicl;

                        if (lookingForSpot < 100)
                        {
                            if (listOfVehicle[lookingForSpot + 100].Type == IVehicle.VehicleType.MC)
                            {
                                vehicl = listOfVehicle[lookingForSpot + 100];
                                listOfVehicle[lookingForSpot + 100] = listOfVehicle[(lookingForSpot)] = vehicl;
                            }
                            Console.WriteLine("Vehicle {0} moved to spot {1}, which also contains {2},",
                               listOfVehicle[determindSpot + 100].regNumber,
                               determindSpot + 1,
                               listOfVehicle[determindSpot].regNumber);
                        }

                        else if (listOfVehicle[determindSpot].Type == IVehicle.VehicleType.Empty)
                        {
                            IVehicle vehicle = listOfVehicle[determindSpot];
                            listOfVehicle[determindSpot] = listOfVehicle[lookingForSpot] = vehicle;

                            if (lookingForSpot < 100)
                            {
                                if (listOfVehicle[lookingForSpot + 100].Type == IVehicle.VehicleType.MC)
                                {
                                    vehicle = listOfVehicle[lookingForSpot + 100];
                                    listOfVehicle[lookingForSpot + 100] = listOfVehicle[lookingForSpot] = vehicle;
                                }
                            }
                            Console.WriteLine("{0} ({1}) moved to spot {2}", listOfVehicle[determindSpot].regNumber,
                                listOfVehicle[determindSpot].Type.ToString(), determindSpot + 1);
                        }
                        else
                        {
                            Console.WriteLine("There is no place for your vehicle {0} in {1}",
                                listOfVehicle[lookingForSpot].regNumber, determindSpot);
                        }
                    }

                    ReadWrite rw = new ReadWrite();
                    try
                    {
                        rw.WriteDataBase(listOfVehicle);
                    }
                    catch (FileNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }


            /// <summary>
            /// Method to look for vehicles in the garage
            /// </summary>
            private void SearchVehicle()
            {
                string regnr = GetRegNum();
                int spotIndex = SearchForSpot(regnr);
                if (spotIndex < 0)
                {
                    Console.WriteLine("That vehicle ({0}) can't be found at the parking lot, sorry.", regnr);
                }
                else
                {
                    Console.WriteLine(spotIndex);
                }

            }
        }
    }
}
       
