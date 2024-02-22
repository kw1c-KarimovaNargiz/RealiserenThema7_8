using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables initialization
        string carPlate = "18-NF-KZ";
        int carSpeed = 0;
        bool motorRunning = false;
        int currentGear = 0;

        // Welcome message
        ShowWelcomeMessage();

        // Get user's name
        Console.WriteLine("Naam:");
        string userName = Console.ReadLine();

        // User interaction loop
        string userInput = "";
        while (userInput != "afsluiten")
        {
            // Display menu
            Console.WriteLine("1. Start de motor");
            Console.WriteLine("2. Stop de motor");
            Console.WriteLine("3. Versnelling motor up");
            Console.WriteLine("4. Versnelling motor down");
            Console.WriteLine("5. Speed up");
            Console.WriteLine("6. Speed down");
            Console.WriteLine("7. Show info");
            Console.WriteLine("Geef een keuze:");

            // Read user input
            userInput = Console.ReadLine();

            // Handle user input
            switch (userInput)
            {
                case "1":
                    motorRunning = StartMotor();
                    Console.WriteLine("Motor gestart. ");
                    break;
                case "2":
                    motorRunning = StopMotor();
                    Console.WriteLine("Motor gestopt");
                    break;
                case "3":
                    currentGear = GearUp(currentGear);
                    Console.WriteLine($"Versnelling omhoog, {currentGear}");
                    break;
                case "4":
                    currentGear = GearDown(currentGear);
                    Console.WriteLine($"Versnelling omlaag, {currentGear}");
                    break;
                case "5":
                    carSpeed = CarSpeedUp(carSpeed, currentGear, motorRunning);
                    Console.WriteLine($"Sneller, nieuwe snelheid: {carSpeed} km/h");
                    break;
                case "6":
                    carSpeed = CarSpeedDown(carSpeed, currentGear, motorRunning);
                    Console.WriteLine($"Langzamer, nieuwe snelheid: {carSpeed} km/h");
                    break;
                case "7":
                    ShowInfo(userName, carPlate, carSpeed, motorRunning, currentGear);
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again :)");
                    break;
            }
        }
    }


    static void ShowWelcomeMessage()
    {
        Console.WriteLine("Welkom");
    }

    // motor start/stop

    static bool StartMotor()
    {
      
        return true; 
    }

    
    static bool StopMotor()
    {
        return false; 
    }


    // versnelling - koppeling
    static int GearUp(int currentGear)
    {
        currentGear++;

        if (currentGear > 5)
        {
            currentGear = 5;
        }

        Console.WriteLine($"Versnelling up: {currentGear}");

        return currentGear;
    }

    // "    "

    static int GearDown(int currentGear)
    {
        currentGear--;

        if (currentGear < 0)
        {
            currentGear = 0;
        }

        Console.WriteLine($"Versnelling down: {currentGear}");

        return currentGear;
    }


    // snelheid

    static int CarSpeedUp(int currentSpeed, int currentGear, bool motorRunning)
    {
        if (motorRunning && currentSpeed < 160)
        {
            currentSpeed += 10;
        }
       
        return currentSpeed;
    }

    // "  "
    static int CarSpeedDown(int currentSpeed, int currentGear, bool motorRunning)
    {

        if (motorRunning && currentGear > 0)
        {
            currentSpeed = 0;
        }

        if (motorRunning && currentGear > 0 )
        {
            return currentSpeed - 10;
        }
        else
        {
            return currentSpeed;
        }
    }


    // remmen!

    static int carBrake(int currentSpeed, bool motorRunning)
    {
        if(motorRunning && currentSpeed > 0)
        {
            currentSpeed -= 10;
        }
        else if (!motorRunning)
        {
            Console.WriteLine("Kunt niet remmen, motor staat stil");
        }
        else
        {
            Console.WriteLine("Kunt niet remmen, auto staat al stil");
        }
        return currentSpeed;
    }
        
    // Method to show car information
    static void ShowInfo(string userName, string carPlate, int carSpeed, bool motorRunning, int currentGear)
    {
        Console.WriteLine($"Naam: {userName}");
        Console.WriteLine($"Nummerplaat: {carPlate}");
        Console.WriteLine($"Snelheid: {carSpeed} km/h");
        Console.WriteLine($"Motor draait: {(motorRunning ? "Ja" : "Nee")}");
        Console.WriteLine($"Huidige versnelling: {currentGear}");
    }
}
