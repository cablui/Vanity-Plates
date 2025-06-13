
namespace VanityPlates
{
    internal class Plate
    {
        public string PlateNumber(string plateNumber)
        {
            string valid = "Valid";
            string invalid = "Invalid";
            bool specialChar = false;
            bool isValid = true;

            foreach (char c in plateNumber)
            {
                if (!char.IsLetterOrDigit(c) && c != ' ')
                {
                    specialChar = true;
                }
            }

            if (specialChar || plateNumber.Length < 2 || plateNumber.Length > 6)
            {
                Console.WriteLine(invalid);
                isValid = false;
            }

            else if (char.IsNumber(plateNumber[0]) || char.IsNumber(plateNumber[1]))
            {
                Console.WriteLine(invalid);
                isValid = false;
            }

            else if (plateNumber.Length > 2)
            {
                if (plateNumber[2] == '0')
                {
                    Console.WriteLine(invalid);
                    isValid = false;
                }

                if (plateNumber.Length > 3)
                {
                    if (char.IsLetter(plateNumber[2]) && plateNumber[3] == '0')
                    {
                        Console.WriteLine(invalid);
                        isValid = false;
                    }

                    if (char.IsNumber(plateNumber[2]) && char.IsLetter(plateNumber[3]))
                    {
                        Console.WriteLine(invalid);
                        isValid = false;
                    }
                }

                if (plateNumber.Length > 4)
                {
                    if (plateNumber[4] == '0')
                    {
                        if (!char.IsNumber(plateNumber[2]) || !char.IsNumber(plateNumber[3]))
                        {
                            Console.WriteLine(invalid);
                            isValid = false;
                        }
                    }

                    if (char.IsNumber(plateNumber[2]) || char.IsNumber(plateNumber[3]) && char.IsLetter(plateNumber[4]))
                    {
                        Console.WriteLine(invalid);
                        isValid = false;
                    }

                }

                if (plateNumber.Length > 5)
                {
                    if (plateNumber[5] == '0')
                    {
                        if (!char.IsNumber(plateNumber[2]) || !char.IsNumber(plateNumber[3]) || !char.IsNumber(plateNumber[4]))
                        {
                            Console.WriteLine(invalid);
                            isValid = false;
                        }
                    }

                    if (char.IsNumber(plateNumber[2]) || char.IsNumber(plateNumber[3]) || char.IsNumber(plateNumber[3]) &&
                        char.IsLetter(plateNumber[4]))
                    {
                        Console.WriteLine(invalid);
                        isValid = false;
                    }
                }
            }

            if (isValid)
            {
                Console.WriteLine(valid);
            }

            return plateNumber;
        }

    }
}
