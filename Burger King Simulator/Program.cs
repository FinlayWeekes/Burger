using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Collections.Concurrent;

public class MainBurger
{
    //all scenes
    public static void EnterBurgerKing(ref bool yes, ref bool no, ref string response, ref string cashier, ref bool reset, ref string endingAmmount, string[,] Ending, ref bool flag, ref string god, ref string judge, ref bool rebel, string[,] SecretEnding, ref string secretEndingAmmount, ref string person)
    {
        do
        {
            LogicBurger.flag = false;
            Console.WriteLine("{0} Welcome to \u001b[34mBurger King\u001b[0m, can I take your order?", cashier);
            LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
            if(yes == true && reset == false)
            {
                rebel = false;
                do
                {
                    LogicBurger.flag = false;
                    Console.WriteLine("{0} What would you like to order?", cashier);
                    Menu();
                    LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                    if((((response == "Help") || (response == "HELP")) || (response == "help")) && reset == false)
                    {
                        Console.Write("{0} Please help me,", cashier);
                        Console.ReadLine();
                        Console.Write("{0} the \u001b[34mBurger King\u001b[0m has me under control.", cashier);
                        Console.ReadLine();
                        Console.Write("{0} I will probably be \u001b[33mslain\u001b[0m for what I have said.", cashier);
                        Console.ReadLine();
                        Console.Write("{0} He has us all under his control,", cashier);
                        Console.ReadLine();
                        Console.Write("{0} we don't have free will.", cashier);
                        Console.ReadLine();
                        Console.Write("{0} Anyone who eats the \u001b[34mWHOPPER®\u001b[0m,", cashier);
                        Console.ReadLine();
                        Console.Write("{0} will be turned over to him.", cashier);
                        Console.ReadLine();
                        Console.Write("You ask why they can't just walk out.");
                        Console.ReadLine();
                        Console.Write("{0} Anyone of the employees who walks out of the front door,", cashier);
                        Console.ReadLine();
                        Console.Write("{0} gets \u001b[33mvaporised\u001b[0m.", cashier);
                        Console.ReadLine();
                        Console.Write("{0} but I have a plan,", cashier);
                        Console.ReadLine();
                        Console.Write("{0} if we find another way out that isn't the front door,", cashier);
                        Console.ReadLine();
                        Console.Write("{0} we might be able to get out.", cashier);
                        Console.ReadLine();
                        Console.Write("You ask thier name");
                        Console.ReadLine();
                        cashier = "\u001b[33mMulberry- \u001b[0m";
                        Console.Write("{0} \u001b[33mMulberry Marshal\u001b[0m", cashier);
                        Console.ReadLine();
                        do
                        {
                            LogicBurger.flag = false;
                            Console.WriteLine("Do you help them?");
                            LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                            if(yes == true && reset == false)
                            {
                                TrueSecretEnding(LogicBurger.secretEndingAmmount, SecretEnding, cashier);
                            }
                            else if(no == true && reset == false)
                            {
                                VaporisedSecretEnding(LogicBurger.secretEndingAmmount, SecretEnding);
                            }
                            else if (reset == false)
                            {
                                Console.WriteLine("{0}What is bro waffling about, do that again", god);
                                Console.ReadLine();
                                LogicBurger.flag = true;
                            }
                            reset = true;
                        }
                        while(LogicBurger.flag == true);
                    }
                    else if(response == "Whopper, Whopper, Whopper, Whopper" && reset == false)
                    {
                        JammingOutSecretEnding(LogicBurger.secretEndingAmmount, SecretEnding, cashier);
                    }
                    else if ((response == "Whopper" || response == "whopper" || response == "WHOPPER" || response == "hamburger" || response == "Hamburger" || response == "espresso" || response == "Espresso" || response == "loaded king fries" || response == "Loaded king fries" || response == "peppercorn angus" || response == "Peppercorn angus") && reset == false)
                    {
                        string meal = response;
                        Console.WriteLine("");
                        EnterSeatingArea(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref meal, ref person);
                    }
                    else if (((response == "NUPKCI") || (response == "nupkci")) && reset == false)
                    {
                        Console.WriteLine("");
                        //you are trying to cheat aren't you
                        //theres no need
                        //if you look at them then you are admiting to yourself that you are bad at computing
                        //but if you want a hint, for the ºß¬í, it in not translated to text, and it also spells an accual phrase
                        do
                        {
                            LogicBurger.flag = false;
                            Console.WriteLine("{0} 01010111 01001000 01001111 01010000 01010000 01000101 01010010 00001010 (can always type r)", cashier);
                            LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                            if(response == "WHOPPER" && reset == false)
                            {
                                Console.WriteLine("");
                                do
                                {
                                    LogicBurger.flag = false;
                                    Console.WriteLine("{0} YnVyZ2VyIGtpbmc= (can always type r)", cashier);
                                    LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                                    if(response == "burger king" && reset == false)
                                    {
                                        Console.WriteLine("");
                                        do
                                        {
                                        LogicBurger.flag = false;
                                        Console.WriteLine("{0} ºß¬í (can always tye r)", cashier);
                                        LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                                        if(((response == "BAD FACED") || response == "bad faced") && reset == false)
                                        {
                                            HackerManSecretEnding(LogicBurger.secretEndingAmmount, SecretEnding, cashier);
                                        }
                                        else if (reset == false)
                                        {
                                            Console.WriteLine("{0}What is bro waffling about, do that again", god);
                                            Console.ReadLine();
                                            LogicBurger.flag = true;
                                        }
                                        reset = true;
                                    }
                                    while(LogicBurger.flag == true);
                                    }
                                    else if (reset == false)
                                    {
                                        Console.WriteLine("{0}What is bro waffling about, do that again", god);
                                        Console.ReadLine();
                                        LogicBurger.flag = true;
                                    }
                                    reset = true;
                                }
                                while(LogicBurger.flag == true);
                            }
                            else if (reset == false)
                            {
                                Console.WriteLine("{0}What is bro waffling about, do that again", god);
                                Console.ReadLine();
                                LogicBurger.flag = true;
                            }
                            reset = true;
                        }
                        while(LogicBurger.flag == true);
                    }
                    else if (reset == false)
                    {
                        Console.WriteLine("{0}What is bro waffling about, do that again", god);
                        Console.ReadLine();
                        LogicBurger.flag = true;
                    }
                    reset = true;
                }
                while(LogicBurger.flag == true);
            }
            else if(no == true && reset == false)
            {
                Console.Write("{0}\u001b[36;3m *Dies of cringe*\u001b[0m", cashier);
                Console.ReadLine();
                do
                {
                    LogicBurger.flag = false;
                    Console.WriteLine("Do you Run?");
                    LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                    if(yes == true && reset == false)
                    {
                        rebel = false;
                        Console.Write("You sprint out of the \u001b[34mBurger King\u001b[0m,");
                        Console.ReadLine();
                        Console.Write("you make it back to your house.");
                        Console.ReadLine();
                        Console.Write("You are constanly thinking about the \u001b[33mpolice\u001b[0m");
                        Console.ReadLine();
                        Console.Write("and what would happen if \u001b[33mthey\u001b[0m came.");
                        Console.ReadLine();
                        Console.Write("You go to bed paranoid about what might happen if you leave the house.");
                        Console.ReadLine();
                        Console.Write("In the morning,");
                        Console.ReadLine();
                        Console.Write("there is a \u001b[33mknock\u001b[0m at the door.");
                        Console.ReadLine();
                        do
                        {
                            LogicBurger.flag = false;
                            Console.WriteLine("Do you answer it?");
                            LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                            if(yes == true && reset == false)
                            {
                                MeetCharlie(ref LogicBurger.yes, ref LogicBurger.no, ref LogicBurger.response, ref LogicBurger.cashier, ref LogicBurger.reset, ref LogicBurger.endingAmmount, Ending, ref LogicBurger.flag, ref LogicBurger.god, ref LogicBurger.judge, ref LogicBurger.rebel, SecretEnding, ref secretEndingAmmount, ref person);
                            }
                            else if(no == true && reset == false)
                            {
                                for(int i = 0; i < 4; i++)
                                {
                                    Console.Write("You ingore the knocking, thinking it is the police.");
                                    Console.ReadLine();
                                    Console.Write("You go back to bed without leaving the house.");
                                    Console.ReadLine();
                                    Console.Write("You feel a little bit more paranoid");
                                    Console.ReadLine();
                                    Console.Write("In the morning,");
                                    Console.ReadLine();
                                    Console.Write("there is another \u001b[33mknock\u001b[0m at the door.");
                                    Console.ReadLine();
                                    do
                                    {
                                        LogicBurger.flag = false;
                                        Console.WriteLine("Do you answer it?");
                                        LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                                        if (reset == false && no == false && yes == false)
                                        {
                                            Console.WriteLine("{0}What is bro waffling about, do that again", god);
                                            Console.ReadLine();
                                            LogicBurger.flag = true;
                                        }
                                        reset = true;
                                    }
                                    while(LogicBurger.flag == true);
                                    if(yes == true)
                                    {
                                        break;
                                    }
                                }
                                if (yes == true)
                                {
                                    MeetCharlie(ref LogicBurger.yes, ref LogicBurger.no, ref LogicBurger.response, ref LogicBurger.cashier, ref LogicBurger.reset, ref LogicBurger.endingAmmount, Ending, ref LogicBurger.flag, ref LogicBurger.god, ref LogicBurger.judge, ref LogicBurger.rebel, SecretEnding, ref secretEndingAmmount, ref person);
                                }
                                else
                                {
                                    InsanityEnding(LogicBurger.endingAmmount, Ending);
                                }
                            }
                            else if (reset == false)
                            {
                                Console.WriteLine("{0}What is bro waffling about, do that again", god);
                                Console.ReadLine();
                                LogicBurger.flag = true;
                            }
                            reset = true;
                        }
                        while(LogicBurger.flag == true);
                    }
                    else if(no == true && reset == false)
                    {
                        EnterCourt(ref LogicBurger.yes, ref LogicBurger.no, ref LogicBurger.response, ref LogicBurger.cashier, ref LogicBurger.reset, ref LogicBurger.endingAmmount, Ending, ref LogicBurger.flag, ref LogicBurger.god, ref LogicBurger.judge, ref LogicBurger.rebel, SecretEnding, ref secretEndingAmmount, ref person);
                    }
                    else if (reset == false)
                    {
                        Console.WriteLine("{0}What is bro waffling about, do that again", god);
                        Console.ReadLine();
                        LogicBurger.flag = true;
                    }
                    reset = true;
                }
                while(LogicBurger.flag == true);
            }
            /*
            else if (response == "" && reset == false)
            {
                MetaSecretEnding(LogicBurger.secretEndingAmmount, SecretEnding, LogicBurger.cashier);
            }
            */
            else if (reset == false)
            {
                Console.WriteLine("{0}What is bro waffling about, do that again", god);
                Console.WriteLine("");
                LogicBurger.flag = true;
            }
            reset = true;
        }
        while(LogicBurger.flag == true);
    }
    
    public static void EnterCourt(ref bool yes, ref bool no, ref string response, ref string cashier, ref bool reset, ref string endingAmmount, string[,] Ending, ref bool flag, ref string god, ref string judge, ref bool rebel, string[,] SecretEnding, ref string secretEndingAmmount, ref string person)
    {
        Console.Write("You find yourself in court,");
        Console.ReadLine();
        Console.Write("there is a \u001b[33mjudge\u001b[0m staring you down,");
        Console.ReadLine();
        Console.Write("you overhear the judge is named \u001b[33mMr.Plachciak\u001b[0m.");
        Console.ReadLine();
        do
        {
            LogicBurger.flag = false;
            Console.WriteLine("\u001b[33mMr.Plachciak- \u001b[0mDo you plead \u001b[33mnot guilty\u001b[0m to this act of manslaughter?");
            LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
            if(yes == true && reset == false)
            {
                LogicBurger.rebel = false;
                Console.WriteLine("\u001b[33mMr.Plachciak- \u001b[0mWhat would you like to say in defence?");
                Console.ReadLine();
                Console.WriteLine("");
                Console.Write("\u001b[33mMr.Plachciak- \u001b[0mWhat is blood \u001b[36;1mYAPPING\u001b[0m about");
                Console.ReadLine();
                Console.Write("\u001b[33mMr.Plachciak- \u001b[0mNah brudda, you're goin' jail.");
                Console.ReadLine();
                Console.WriteLine("");
                EnterPrison(ref LogicBurger.yes, ref LogicBurger.no, ref LogicBurger.response, ref LogicBurger.cashier, ref LogicBurger.reset, ref LogicBurger.endingAmmount, Ending, ref LogicBurger.flag, ref LogicBurger.god, ref LogicBurger.judge, ref LogicBurger.rebel, SecretEnding, ref secretEndingAmmount, ref person);

            }
            else if(no == true && reset == false)
            {
                EnterPrison(ref LogicBurger.yes, ref LogicBurger.no, ref LogicBurger.response, ref LogicBurger.cashier, ref LogicBurger.reset, ref LogicBurger.endingAmmount, Ending, ref LogicBurger.flag, ref LogicBurger.god, ref LogicBurger.judge, ref LogicBurger.rebel, SecretEnding, ref secretEndingAmmount, ref person);
            }
            else if (reset == false)
            {
                Console.WriteLine("{0}What is bro waffling about, do that again", god);
                Console.ReadLine();
                LogicBurger.flag = true;
            }
            reset = true;
        }
        while(LogicBurger.flag == true);
    }

    public static void EnterPrison(ref bool yes, ref bool no, ref string response, ref string cashier, ref bool reset, ref string endingAmmount, string[,] Ending, ref bool flag, ref string god, ref string judge, ref bool rebel, string[,] SecretEnding, ref string secretEndingAmmount, ref string person)
    {
        Console.Write("You find yourself in prison,");
        Console.ReadLine();
        Console.Write("you are being escorted to your cell");
        Console.ReadLine();
        Console.Write("when you notice a \u001b[33mknife\u001b[0m on the floor that you can grab.");
        Console.ReadLine();
        do
        {
            LogicBurger.flag = false;
            Console.WriteLine("Do you attack the officer?");
            LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
            if(yes == true && reset == false)
            {
                ShotDeadByHarryCEnding(LogicBurger.endingAmmount, Ending);
            }
            else if(no == true && reset == false)
            {
                Console.Write("You get taken to your cell");
                Console.ReadLine();
                Console.Write("where you see two prisoners \u001b[33mfighting\u001b[0m.");
                Console.ReadLine();
                do
                {
                    LogicBurger.flag = false;
                    Console.WriteLine("Do you join in?");
                    LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                    if(yes == true && reset == false)
                    {
                        Console.Write("In the fight, you can clearly see someone is winning,");
                        Console.ReadLine();
                        Console.Write("one prisoner is on the floor with another stood over him with a \u001b[33mshank\u001b[0m.");
                        Console.ReadLine();
                        Console.Write("They start shouting and you can make out thier names,");
                        Console.ReadLine();
                        Console.Write("the prisoner on the floor is named \u001b[33mJenson\u001b[0m,");
                        Console.ReadLine();
                        Console.Write("and the prisoner above him is named \u001b[33mNasir\u001b[0m.");
                        Console.ReadLine();
                        do
                        {
                            LogicBurger.flag = false;
                            Console.WriteLine("Do you attack \u001b[33mNasir\u001b[0m, who is winning(type \u001b[32my\u001b[0m)?");
                            Console.WriteLine("Or do you attack \u001b[33mJenson\u001b[0m, who is losing(type \u001b[31mn\u001b[0m)?");
                            LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                            if(yes == true && reset == false)
                            {
                                CheffedUpByNasirEnding(LogicBurger.endingAmmount, Ending);
                            }
                            else if(no == true && reset == false)
                            {
                                GassedOutByJensonEnding(LogicBurger.endingAmmount, Ending);
                            }
                            else if (reset == false)
                            {
                                Console.WriteLine("{0}What is bro waffling about, do that again", god);
                                Console.ReadLine();
                                LogicBurger.flag = true;
                            }
                            reset = true;
                        }
                        while(LogicBurger.flag == true);
                    }
                    else if(no == true && reset == false)
                    {
                        Console.Write("You wait out your days in prison for over a decade.");
                        Console.ReadLine();
                        Console.Write("though it did not feel that long.");
                        Console.ReadLine();
                        Console.Write("you are now outside, free to go anywhere.");
                        Console.ReadLine();
                        do
                        {
                            LogicBurger.flag = false;
                            Console.WriteLine("Go back to \u001b[34mBurger King\u001b[0m?");
                            LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                            if(yes == true && reset == false)
                            {
                                EnterBurgerKing2(ref LogicBurger.yes, ref LogicBurger.no, ref LogicBurger.response, ref LogicBurger.cashier, ref LogicBurger.reset, ref LogicBurger.endingAmmount, Ending, ref LogicBurger.flag, ref LogicBurger.god, ref LogicBurger.judge, ref LogicBurger.rebel, SecretEnding, ref secretEndingAmmount, ref person);
                            }
                            else if(no == true && reset == false)
                            {
                                do
                                {
                                    LogicBurger.flag = false;
                                    Console.WriteLine("Do you go back \u001b[33mhome\u001b[0m?");
                                    LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                                    if(yes == true && reset == false)
                                    {
                                        NoBurgerEnding(LogicBurger.endingAmmount, Ending);
                                    }
                                    else if(no == true && reset == false && rebel == true)
                                    {
                                        Console.Write("damn");
                                        Console.ReadLine();
                                        Console.Write("you just disagree with everything don't you");
                                        Console.ReadLine();
                                        Console.Write("your really making it hard for me");
                                        Console.ReadLine();
                                        Console.Write("fine.");
                                        Console.ReadLine();
                                        do
                                        {
                                            LogicBurger.flag = false;
                                            Console.WriteLine("Do you NOT go back \u001b[33mhome\u001b[0m?");
                                            LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                                            if(yes == true && reset == false)
                                            {
                                                Console.WriteLine("You are really pushing me here.");
                                                Console.ReadLine();
                                                do
                                                {
                                                    LogicBurger.flag = false;
                                                    Console.WriteLine("Don't you not really not want to not go back \u001b[33mhome\u001b[0m?");
                                                    LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                                                    if(yes == true && reset == false)
                                                    {
                                                        NoBurgerEnding(LogicBurger.endingAmmount, Ending);
                                                    }
                                                    else if(no == true && reset == false)
                                                    {
                                                        Console.Write("\u001b[41;1mAGGGHHHAGAAAAHAHA\u001b[0m");
                                                        Console.ReadLine();
                                                        Console.Write("\u001b[41;1mjust go back home\u001b[0m");
                                                        Console.ReadLine();
                                                        Console.Write("please.");
                                                        Console.ReadLine();
                                                        do
                                                        {
                                                            LogicBurger.flag = false;
                                                            Console.WriteLine("\u001b[31;1mdon't you not feel conflicted about not going to not the not place where your un-home is not but the opposite?\u001b[0m");
                                                            LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                                                            if(yes == true && reset == false)
                                                            {
                                                                NoBurgerEnding(LogicBurger.endingAmmount, Ending);
                                                            }
                                                            else if(no == true && reset == false)
                                                            {
                                                                RebelEnding(LogicBurger.endingAmmount, Ending);
                                                            }
                                                            else if (reset == false)
                                                            {
                                                                Console.WriteLine("{0}What is bro waffling about, do that again", god);
                                                                Console.ReadLine();
                                                                LogicBurger.flag = true;
                                                            }
                                                            reset = true;
                                                        }
                                                        while(LogicBurger.flag == true);
                                                    }
                                                    else if (reset == false)
                                                    {
                                                        Console.WriteLine("{0}What is bro waffling about, do that again", god);
                                                        Console.ReadLine();
                                                        LogicBurger.flag = true;
                                                    }
                                                    reset = true;
                                                }
                                                while(LogicBurger.flag == true);
                                            }
                                            else if(no == true && reset == false)
                                            {
                                                NoBurgerEnding(LogicBurger.endingAmmount, Ending);
                                            }
                                            else if (reset == false)
                                            {
                                                Console.WriteLine("{0}What is bro waffling about, do that again", god);
                                                Console.ReadLine();
                                                LogicBurger.flag = true;
                                            }
                                            reset = true;
                                        }
                                        while(LogicBurger.flag == true);
                                    }
                                    else if (no == true && reset == false && rebel == false)
                                    {
                                        DementiaEnding(LogicBurger.endingAmmount, Ending);
                                    }
                                    else if (reset == false)
                                    {
                                        Console.WriteLine("{0}What is bro waffling about, do that again", god);
                                        Console.ReadLine();
                                        LogicBurger.flag = true;
                                    }
                                    reset = true;
                                }
                                while(LogicBurger.flag == true);
                            }
                            else if (reset == false)
                            {
                                Console.WriteLine("{0}What is bro waffling about, do that again", god);
                                Console.ReadLine();
                                LogicBurger.flag = true;
                            }
                            reset = true;
                        }
                        while(LogicBurger.flag == true);
                    }
                    else if (reset == false)
                    {
                        Console.WriteLine("{0}What is bro waffling about, do that again", god);
                        Console.ReadLine();
                        LogicBurger.flag = true;
                    }
                    reset = true;
                }
                while(LogicBurger.flag == true);
            }
            else if (reset == false)
            {
                Console.WriteLine("{0}What is bro waffling about, do that again", god);
                Console.ReadLine();
                LogicBurger.flag = true;
            }
            reset = true;
        }
        while(LogicBurger.flag == true);
    }

    public static void EnterBurgerKing2(ref bool yes, ref bool no, ref string response, ref string cashier, ref bool reset, ref string endingAmmount, string[,] Ending, ref bool flag, ref string god, ref string judge, ref bool rebel, string[,] SecretEnding, ref string secretEndingAmmount, ref string person)
    {
        Console.Write("{0} Welcome to \u001b[34mBurger King\u001b[0m, can I take your order?", cashier);
        Console.ReadLine();
        Console.Write("{0} Wait, aren't you the perso who \u001b[31mkilled\u001b[0m that poor cashier 15 years ago?", cashier);
        Console.ReadLine();
        Console.Write("{0} That was \u001b[33mMulberry\u001b[0m that you \u001b[31mmurdered\u001b[0m in \u001b[31mcold blood.\u001b[0m", cashier);
        Console.ReadLine();
        Console.Write("{0} You have been banned from entering a \u001b[34mBurger King\u001b[0m ever again.", cashier);
        Console.ReadLine();
        Console.Write("You see on thier nametag that they are named \u001b[33mGeorge\u001b[0m");
        Console.ReadLine();
        do
        {
            LogicBurger.flag = false;
            Console.WriteLine("Do you leave?");
            LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
            if(yes == true && reset == false)
            {
                ExiledEnding(LogicBurger.endingAmmount, Ending);
            }
            else if(no == true && reset == false)
            {
                LifeSentenceEnding(LogicBurger.endingAmmount, Ending, LogicBurger.cashier);
            }
            else if (reset == false)
            {
                Console.WriteLine("{0}What is bro waffling about, do that again", god);
                Console.ReadLine();
                LogicBurger.flag = true;
            }
            reset = true;
        }
        while(LogicBurger.flag == true);
    }

    public static void MeetCharlie(ref bool yes, ref bool no, ref string response, ref string cashier, ref bool reset, ref string endingAmmount, string[,] Ending, ref bool flag, ref string god, ref string judge, ref bool rebel, string[,] SecretEnding, ref string secretEndingAmmount, ref string person)
    {
        Console.Write("\u001b[33mCharlie-\u001b[0m Hi, i'm \u001b[33mCharlie Pilkington\u001b[0m.");
        Console.ReadLine();
        Console.Write("\u001b[33mCharlie-\u001b[0m Would you like to purchase this a tennis racket?");
        Console.ReadLine();
        Console.Write("You thought this was just a lowly salesman.");
        Console.ReadLine();
        Console.Write("\u001b[33mCharlie-\u001b[0m If you don't want it let me show you something about it.");
        Console.ReadLine();
        Console.Write("\u001b[33mCharlie-\u001b[0m I bet I can hit this tennis ball over \u001b[33m150mph\u001b[0m!");
        Console.ReadLine();
        do
            {
                LogicBurger.flag = false;
                Console.WriteLine("Can \u001b[33mCharlie\u001b[0m hit the ball over \u001b[33m150mph\u001b[0m?");
                LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                
                Random random = new Random();
                int bet = random.Next(1, 3);
                if ((bet == 1 && reset == false) && (yes == true || no == true))
                {
                    int mph1 = random.Next(140,150);
                    Console.Write("\u001b[33mCharlie Pilkington\u001b[0m hit the tennis ball \u001b[33m{0}mph\u001b[0m", mph1);
                    Console.ReadLine();
                }
                else if((bet == 2 && reset == false) && (yes == true || no == true))
                {
                    int mph2 = random.Next(151,160);
                    Console.Write("\u001b[33mCharlie Pilkington\u001b[0m hit the tennis ball \u001b[33m{0}mph\u001b[0m", mph2);
                    Console.ReadLine();
                }
                if ((bet == 1 && reset == false && yes == true))
                {
                    Console.Write("\u001b[33mCharlie-\u001b[0m I lost...");
                    Console.ReadLine();
                    Console.Write("\u001b[33mCharlie-\u001b[0m \u001b[36;3m*Dies of cringe*\u001b[0m");
                    Console.ReadLine();
                    DeathByCringeEnding(LogicBurger.endingAmmount, Ending);
                }
                else if ((bet == 2 && reset == false && no == true))
                {
                    Console.Write("\u001b[33mCharlie-\u001b[0m I won!");
                    Console.ReadLine();
                    DeathByCringeEnding(LogicBurger.endingAmmount, Ending);
                }
                else if ((bet == 1 && reset == false && no == true))
                {
                    Console.Write("\u001b[33mCharlie-\u001b[0m I lost...");
                    Console.ReadLine();
                    Console.Write("\u001b[33mCharlie-\u001b[0m \u001b[36;3m*Dies of cringe*\u001b[0m");
                    Console.ReadLine();
                    EnterCourt(ref LogicBurger.yes, ref LogicBurger.no, ref LogicBurger.response, ref LogicBurger.cashier, ref LogicBurger.reset, ref LogicBurger.endingAmmount, Ending, ref LogicBurger.flag, ref LogicBurger.god, ref LogicBurger.judge, ref LogicBurger.rebel, SecretEnding, ref secretEndingAmmount, ref person);
                }
                else if ((bet == 2 && reset == false && yes == true))
                {
                    GetScammedEnding(LogicBurger.endingAmmount, Ending);
                }
                else if (reset == false)
                {
                    Console.WriteLine("{0}What is bro waffling about, do that again", god);
                    Console.ReadLine();
                    LogicBurger.flag = true;
                }
                reset = true;
            }
            while(LogicBurger.flag == true);
    }
    
    public static void EnterSeatingArea(ref bool yes, ref bool no, ref string response, ref string cashier, ref bool reset, ref string endingAmmount, string[,] Ending, ref bool flag, ref string god, ref string judge, ref bool rebel, string[,] SecretEnding, ref string secretEndingAmmount, ref string meal, ref string person) 
    {
        Console.Write("You go to find a place to sit down but,");
        Console.ReadLine();
        Console.Write("all of the seats are \u001b[33mtaken\u001b[0m!");
        Console.ReadLine();
        Console.Write("You think to yourslef that you are going to die,");
        Console.ReadLine();
        Console.Write("if you do not find a seat.");
        Console.ReadLine();
        Console.Write("There is two tables that you think you could take.");
        Console.ReadLine();
        Console.Write("The first table has \u001b[33mthree people\u001b[0m sitting on it,");
        Console.ReadLine();
        Console.Write("you overhear thier names are");
        Console.ReadLine();
        Console.Write("\u001b[33mBenny\u001b[0m, \u001b[33mFayaz\u001b[0m and \u001b[33mRudy\u001b[0m.");
        Console.ReadLine();
        Console.Write("The second table also has \u001b[33mthree people\u001b[0m sitting on it,");
        Console.ReadLine();
        Console.Write("you overhear thier names are");
        Console.ReadLine();
        Console.Write("\u001b[33mDaniel\u001b[0m, \u001b[33mHarry Woods\u001b[0m and \u001b[33mQuoc\u001b[0m.");
        Console.ReadLine();
        do
        {
            LogicBurger.flag = false;
            Console.WriteLine("Do you attack \u001b[33mBenny\u001b[0m, \u001b[33mFayaz\u001b[0m and \u001b[33mRudy\u001b[0m(type \u001b[32my\u001b[0m)?");
            Console.WriteLine("Or do you attack \u001b[33mDaniel\u001b[0m, \u001b[33mHarry\u001b[0m and \u001b[33mQuoc\u001b[0m(type \u001b[31mn\u001b[0m)?");
            LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
            if((yes == true || no == true)&& reset == false)
            {
                Console.Write("You go to attack them but,");
                Console.ReadLine();
                Console.Write("just before you do,");
                Console.ReadLine();
                Console.Write("you notice a free table off to the side which you hadn't seen before.");
                Console.ReadLine();
                Console.Write("You sit down and wait for a short ammount of time.");
                Console.ReadLine();
                Console.Write("You soon relise you need to go to the \u001b[33mtoilet\u001b[0m but,");
                Console.ReadLine();
                Console.Write("if you go you might miss your \u001b[33mprized {0}\u001b[0m.", meal);
                Console.ReadLine();
                do
                {
                    LogicBurger.flag = false;
                    Console.WriteLine("Do you go to the \u001b[33mtoilet\u001b[0m (risking missing your {0})?", meal);
                    LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                    if(yes == true && reset == false)
                    {
                         Console.Write("You decide to go to the \u001b[33mtoilet\u001b[0m");
                        Console.ReadLine();
                        Console.Write("because you thought waiting would be too risky.");
                        Console.ReadLine();
                        Console.Write("You walk over to the \u001b[33mtoilets\u001b[0m.");
                        Console.ReadLine();
                        Console.Write("You go to a cubicle but,");
                        Console.ReadLine();
                        Console.Write("they are all \u001b[33mfull\u001b[0m!");
                        Console.ReadLine();
                        Console.Write("There are six cubicles in total");
                        Console.ReadLine();   
                        Console.Write("You really need the \u001b[33mtoilet\u001b[0m");
                        Console.ReadLine();   
                        do
                        {
                            LogicBurger.flag = false;
                            Console.WriteLine("Do you open one?");
                            LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                            if(yes == true && reset == false)
                            {
                                Console.Write("You go to open one of the cubicles and notice,");
                                Console.ReadLine();
                                Console.Write("they are unlocked but before you open one,");
                                Console.ReadLine();
                                Console.Write("you notcie a sign nearby, it reads:");
                                Console.ReadLine();
                                Console.WriteLine("");
                                do
                                {   
                                    LogicBurger.flag = false;
                                    Console.Write("`\u001b[33mAt least one\u001b[0m of these cubicles is \u001b[31munsafe\u001b[0m.");
                                    Console.ReadLine();
                                    Console.Write("\u001b[33mAll of the other\u001b[0m cubicles are \u001b[32msafe\u001b[0m.");
                                    Console.ReadLine();
                                    Console.Write("All of the \u001b[32msafe\u001b[0m cubicles, are always \u001b[32mtruthful\u001b[0m");
                                    Console.ReadLine();
                                    Console.Write("All of the \u001b[31munsafe\u001b[0m cubicles, are always \u001b[31mlying\u001b[0m");
                                    Console.ReadLine();
                                    Console.Write("Here is what they all have to say:");
                                    Console.ReadLine();
                                    Console.WriteLine("\u001b[33mCubicle 1-\u001b[0m Cubicles 3 and 4 are \u001b[32msafe\u001b[0m");
                                    Console.WriteLine("\u001b[33mCubicle 2-\u001b[0m At least two triangle numbered cubicles are \u001b[32msafe\u001b[0m");
                                    Console.WriteLine("\u001b[33mCubicle 3-\u001b[0m All prime number cubicles are \u001b[32msafe\u001b[0m");
                                    Console.WriteLine("\u001b[33mCubicle 4-\u001b[0m All even numbered cubilces are \u001b[31munsafe\u001b[0m");
                                    Console.WriteLine("\u001b[33mCubicle 5-\u001b[0m Palm oil accounts for 15% of Malaysia's GDP");
                                    Console.WriteLine("\u001b[33mCubicle 6-\u001b[0m At least three cubicles are \u001b[31munsafe\u001b[0m`");
                                    Console.WriteLine("Which do you open?(type the number 1-6)");
                                    LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                                    if(response == "1" && reset == false)
                                    {
                                        DeathByLieBennyEnding(LogicBurger.endingAmmount, Ending);
                                    }
                                    else if(response == "2" && reset == false)
                                    {
                                        StarvationEnding(LogicBurger.endingAmmount, Ending);
                                    }
                                    else if(response == "3" && reset == false)
                                    {
                                        StapledEnding(LogicBurger.endingAmmount, Ending);
                                    }
                                    else if (response == "4" && reset == false)
                                    {
                                        BlownAwayEnding(LogicBurger.endingAmmount, Ending);
                                    }
                                    else if(response == "5" && reset == false)
                                    {
                                        EternityOfTormentEnding(LogicBurger.endingAmmount, Ending);
                                    }
                                    else if(response == "6" && reset == false)
                                    {
                                        FameAndRichesEnding(LogicBurger.endingAmmount, Ending);
                                    }
                                    else if (reset == false)
                                    {
                                        Console.WriteLine("{0}What is bro waffling about, do that again", god);
                                        Console.ReadLine();
                                        LogicBurger.flag = true;
                                    }
                                    reset = true;
                                }
                                while(LogicBurger.flag == true);
                            }
                            else if(no == true && reset == false)
                            {
                                Console.Write("You wait outside for a little while.");
                                Console.ReadLine();
                                Console.Write("Good choice as \u001b[33mBenny\u001b[0m just came out of the first cubicle.");
                                Console.ReadLine();
                                Console.Write("You eneter in and do you buissiness.");
                                Console.ReadLine();
                                Console.Write("You come back to realise that,");
                                Console.ReadLine();
                                Console.Write("you took so long that your \u001b[33m{0}\u001b[0m is gone.", meal);
                                Console.ReadLine();
                                do
                                {
                                    LogicBurger.flag = false;
                                    Console.WriteLine("Do you complain?");
                                    LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                                    if(yes == true && reset == false)
                                    {
                                        Console.WriteLine("");
                                        Console.Write("You begin walking over to the cashier to complain but,");
                                        Console.ReadLine();
                                        Console.Write("someone approches you,");
                                        Console.ReadLine();
                                        Console.Write("you feel like you recognise them but you don't know where from.");
                                        Console.ReadLine();
                                        Console.Write("They are named \u001b[33mFinlay\u001b[0m is all you know.");
                                        Console.ReadLine();
                                        Console.Write("\u001b[33mFinlay-\u001b[0m You were about to complain to that cashier about your {0}", meal);
                                        Console.ReadLine();
                                        Console.Write("\u001b[33mFinlay-\u001b[0m wern't you");
                                        Console.ReadLine();
                                        Console.Write("\u001b[33mFinlay-\u001b[0m well I think that is not very nice so,");
                                        Console.ReadLine();
                                        Console.Write("\u001b[33mFinlay-\u001b[0m If you think your so smart.");
                                        Console.ReadLine();
                                        Quiz(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref meal, ref person);
                                    }
                                    else if(no == true && reset == false)
                                    {
                                        RegretEnding(LogicBurger.endingAmmount, Ending);
                                    }
                                    else if (reset == false)
                                    {
                                        Console.WriteLine("{0}What is bro waffling about, do that again", god);
                                        Console.ReadLine();
                                        LogicBurger.flag = true;
                                    }
                                    reset = true;
                                }
                                while(LogicBurger.flag == true);
                            }
                            else if (reset == false)
                            {
                                Console.WriteLine("{0}What is bro waffling about, do that again", god);
                                Console.ReadLine();
                                LogicBurger.flag = true;
                            }
                            reset = true;
                        }
                        while(LogicBurger.flag == true);
                    }
                    else if(no == true && reset == false)
                    {
                        Console.Write("You decide to wait it out.");
                        Console.ReadLine();
                        Console.Write("You relise it might mean you have to let it out here but,");
                        Console.ReadLine();
                        Console.Write("it will be worth it for that \u001b[33m{0}\u001b[0m.", meal);
                        Console.ReadLine();
                        Console.Write("After 5 minutes of waiting,");
                        Console.ReadLine();
                        Console.Write("you feel like you really need to go but");
                        Console.ReadLine();
                        Console.Write("going now would certainly mean you dont get your \u001b[33m{0}\u001b[0m", meal);
                        Console.ReadLine();
                        do
                        {
                            LogicBurger.flag = false;
                            Console.WriteLine("Do you go to the \u001b[33mtoilet\u001b[0m (you won't get your \u001b[33m{0}\u001b[0m)", meal);
                            LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
                            if(yes == true && reset == false)
                            {
                                SonicBlastedEnding(LogicBurger.endingAmmount, Ending);
                            }
                            else if(no == true && reset == false)
                            {
                                HeartAttackEnding(LogicBurger.endingAmmount, Ending);
                            }
                            else if (reset == false)
                            {
                                Console.WriteLine("{0}What is bro waffling about, do that again", god);
                                Console.ReadLine();
                                LogicBurger.flag = true;
                            }
                            reset = true;
                        }
                        while(LogicBurger.flag == true);
                    }
                    else if (reset == false)
                    {
                        Console.WriteLine("{0}What is bro waffling about, do that again", god);
                        Console.ReadLine();
                        LogicBurger.flag = true;
                    }
                    reset = true;
                }
                while(LogicBurger.flag == true);
            }
            else if (reset == false)
            {
                Console.WriteLine("{0}What is bro waffling about, do that again", god);
                Console.ReadLine();
                LogicBurger.flag = true;
            }
            reset = true;
        }
        while(LogicBurger.flag == true);
    }

    public static void Menu()
    {
        Console.WriteLine("MeNu:\n\nHamUrger\nEsPresso\nLoaded King fries\nPepperCorn angus\n\u001b[34mWHOPPER®\u001b[0m\n\n(PIck one)");
    }
    
    static void Quiz(ref bool yes, ref bool no, ref string response, ref string cashier, ref bool reset, ref string endingAmmount, string[,] Ending, ref bool flag, ref string god, ref string judge, ref bool rebel, string[,] SecretEnding, ref string secretEndingAmmount, ref string meal, ref string person)
    {
        Console.Write("\u001b[33mFinlay-\u001b[0m Answer these 10 questions.");
        Console.ReadLine();
        Console.Write("\u001b[33mFinlay-\u001b[0m You will have 60 seconds.");
        Console.ReadLine();
        Console.Write("\u001b[33mFinlay-\u001b[0m There will be one question for each subject.");
        Console.ReadLine();
        Console.Write("\u001b[33mFinlay-\u001b[0m With an extra hard question at the end.");
        Console.ReadLine();
        Console.Write("\u001b[33mFinlay-\u001b[0m This will include subjects that I took (Geography, Latin, Computing, DT)");
        Console.ReadLine();
        Console.Write("\u001b[33mFinlay-\u001b[0m Answer in \u001b[33mALL LOWERCASE\u001b[0m (even for places).");
        Console.ReadLine();
        Console.Write("\u001b[33mFinlay-\u001b[0m Answer with \u001b[33mNO SPACES\u001b[0m (all answers are one word).");
        Console.ReadLine();
        Console.Write("\u001b[33mFinlay-\u001b[0m Answer with \u001b[33mNO COMMAS\u001b[0m for numbers.");
        Console.ReadLine();
        Console.Write("\u001b[33mFinlay-\u001b[0m Answer with \u001b[33mNO SYMBOLS\u001b[0m such as % or .");
        Console.ReadLine();
        Console.Write("\u001b[33mFinlay-\u001b[0m (\u001b[33mexept /\u001b[0m which can be used for fractions and \u001b[33mexept -\u001b[0m for endings and negatives).");
        Console.ReadLine();
        Console.Write("\u001b[33mFinlay-\u001b[0m Good luck.");
        Console.ReadLine();
        Console.Write("\u001b[33mFinlay-\u001b[0m You \u001b[33mlife\u001b[0m depends on it.");
        Console.ReadLine();
        Console.WriteLine("");
        (string question, string answer)[] questions = {
            //geography
            ("What is the main city in the Thar deset", "jaisalmer"),
            ("What is the top layer of a rainforrest called?", "emergent"),
            ("Which type of techtonic crust is newer?", "oceanic"),
            ("Which poor country that experiences earthquakes do we learn about?", "nepal"),
            ("What type of energy is built up berfore an earthquake?", "strain"),
            ("What is 'Old Harry'?", "stack"),
            ("What is the process of rocks being smashed together?", "attrition"),
            ("What percentage of Nigeria's exports is oil?", "98"),
            ("What is the process of rocks being smashed together?", "attrition"),
            ("How many hours is water avaliable in Dharavi?", "2"),
            //chemistry
            ("What needs replacing during electrolysis of aluminium oxide?", "anonde"),
            ("What does this order represent: PSLCMCZIHCSG?", "reactivity"),
            ("What is the process of rocks being smashed together?", "attrition"),
            ("What sepparates liquds from soluble solids?", "crystallisation"),
            ("What colour does flourine gas appear?", "yellow"),
            ("What is a single layer of 3 carbon atoms bonded together?", "graphene"),
            ("Whoose number is: 6.02 x 10²³?", "avogadro"),
            ("What colour does the precipitate of Fe2+ turn to after waiting?", "brown"),
            ("What material is: low density, waterproof and used for plastic bags?", "polyethene"),
            ("What type of bonding happens between two polymers with different function groups?", "condensation"),
            //maths
            ("What is tan130325?", "1"),
            ("What is a line whose distance to a given curve tends to zero?", "asymtope"),
            ("What is the missing type of triangle out of: equilateral, isoceles", "scalene"),
            ("If f(y)=2^y + y, what does f(5)?", "37"),
            ("What is 5!?", "120"),
            ("What has equilateral triangles, therefore, all its interior angles measure 60°.?", "tetrahedron"),
            ("What is cos420?", "1/2"),
            ("What is what transformation describes an object getting smaller?", "enlargement"),
            ("What is how many zeroes are in 69 qaudrilion?", "15"),
            ("What is the biggest number described in one word?", "googleplexian"),
            //biology
            ("What is missing out of this plant cell structure: ribosome, chloroplast, cytoplasm, cell wall, nucleus, vacuole, mitochondia?", "membrane"),
            ("What type of microscope has high resolution?", "electron"),
            ("What type of plate do we create microorganisms on?", "agar"),
            ("What is a group of tissues working together?", "organ"),
            ("What are these: DKCOFGS?", "taxons"),
            ("What is an organism that lives in an extreme place?", "extremophile"),
            ("What type of acids do protiens break down to form?", "amino"),
            ("What type of pathogen is salmonella?", "bacteria"),
            ("What is the sum of all chemical reactions in the body?", "metabolism"),
            ("What type of neurone is activated last during a response?", "motor"),
            //english
            ("What did Carol Rumens write?", "emigree"),
            ("What does the inspector not play?", "golf"),
            ("What is Mr.Birling a `Hard headed man of`?", "buisiness"),
            ("Which poem does the speaker express the futile pursuit of power and its consequences?", "prelude"),
            ("How many gay people in Jekyll and Hyde?", "3"),
            ("What are used as a symbol of truth in Jekyll and Hyde?", "windows"),
            ("How many marks in English Lit paper 1 section A?", "34"),
            ("How many poems in power and conflict?", "15"),
            ("Where did Eva Smith die?", "infirmary"),
            ("What does AO3 refer to in English?", "context"),
            //phsyics
            ("Who made the `left hand rule`?", "fleming"),
            ("What does a circle with an x through represent?", "bulb"),
            ("What potential is 0.5ke^2?", "elastic"),
            ("What percet of the speed of light does Beta radiaton travel?", "90"),
            ("In phsyics, what makes photohgraphic film turn black?", "radiation"),
            ("What element does Uranium decay to?", "thorium"),
            ("Whoose law is this: amps through a conductor between two points is proportional to the volts across the two points?", "ohm"),
            ("What colour is the neutral wire?", "blue"),
            ("In phsyics, what point does `F` stand for?", "focal"),
            ("What type of lens produces a virtual image?", "concave"),
            //latin
            ("What is the plural nominative 2nd declention noun ending?", "-i"),
            ("What is the plural genative 1st declention noun ending?", "-arum"),
            ("What does pecunia mean?", "money"),
            ("How many declentions are there?", "5"),
            ("What is the singular accusative neuter 1st and 2nd declention adjective ending?", "-um"),
            ("What type of adjective is used to show quality or great extent?", "superlative"),
            ("What does cras mean?", "tomorrow"),
            ("What is the word for three thing next to each other in latin?", "tricolon"),
            ("What is the latin word for nominative masculine `this`?", "hic"),
            ("Who is Nero's aunt?", "caligula"),
            //DT
            ("What is the last name of the person who designed the Gherekin?", "foster"),
            ("What can be described as an inital product or sample of a product?", "prototype"),
            ("What term describes the process of refining a product's design based on user feedback?", "iteration"),
            ("What is the manufacturing process where liquid material is poured into a mold and then solidified?", "casting"),
            ("What is a thin surface layer, as of finely grained wood, glued to a base of inferior material which can be bent?", "veneer"),
            ("How many R's are there?", "6"),
            ("What type of wood is beech?", "hardwood"),
            ("What type of saw is next to the sander?", "scrollsaw"),
            ("What type of energy uses water to generate elctricity?", "hydro"),
            ("How many marks on DT paper", "100"),
            //computing
            ("What connects the CPU to multiple components in a computer?", "buses"),
            ("Fill in the blank: what does USB stands for: _______ Serial Bus?", "universal"),
            ("What allows a computer to boot up?", "bios"),
            ("What type of imaging is commonnly used?", "bitmap"),
            ("What stand for the thing which is used as permenant storage in a computer besides SSD?", "hdd"),
            ("What is described as taking measurements to record frequency in music?", "sampling"),
            ("What is the fastest type of cable?", "opti"),
            ("What type of attack involves flooding serves with traffic", "ddos"),
            ("What is used to connect networks besides a hub?", "switch"),
            ("What type of attack involves using set words to crack a password?", "dictionary"),
        };

        (string Hardquestion, string answer)[] Hardquestions = {
            ("What is a material found in the Thar desert that is used for plastics and cement?", "gypsum"),
            ("What is non-stick, used for coating a frying pan and stands for PTFE?", "Polytetrafuoroethene"),
            ("What is y when the area of a rhombus is 250y/5 and its leangth is 2(y+7) and its perpendicular height is 4!?", "112"),
            ("What is used to streangthen xylem?", "lignin"),
            ("What is my least favourite colour?", "yellow"),
            ("What the fith ending of Burger King simulator?", "rebel"),
            ("How many marks for all of English?", "288"),
            ("What type of wave has a larger shadow zone?", "primary"),
            ("What is the word for the non-reflective plural feminine possesive pronoun?", "earum"),
            ("How many slides in my final DT NEA PowerPoint?", "22"),
            ("What is this in decimal: 1010010001010101?", "42069"),
        };

        var timer = new System.Timers.Timer(1000);
        var timeRemaining = 60;
        var userInput = new BlockingCollection<string>();

        var userInputThread = new Thread(() => GetUserInput(userInput));
        userInputThread.Start();

        // Start timer
        timer.Elapsed += (sender, e) =>
        {
            if (timeRemaining > 0)
                timeRemaining--;
            if (timeRemaining <= 0)
            {
                timer.Stop();
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                userInput.Add(null); // Signal timeout
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            }
        };
        timer.Start();

        // Prompt user for each question
        for (int i = 0; i < 10; i++)
        {
            if (i < 9)
            {
                Random random = new Random();
                int num = random.Next(0, 90);

                Console.WriteLine($"\nTime remaining: {timeRemaining} seconds");
                Console.WriteLine($"Question {i+1}: {questions[num].question}");

                string userAnswer = userInput.Take(); // Wait for user input or timeout

                if (userAnswer == null)
                {
                    Grade4Ending(LogicBurger.endingAmmount, Ending);
                    return;
                }

                if (userAnswer.ToLower() != questions[num].answer.ToLower())
                {
                    Grade4Ending(LogicBurger.endingAmmount, Ending);
                    return;
                }
            }
            else if (i == 9)
            {
                Random random = new Random();
                int num = random.Next(0, 12);

                Console.WriteLine($"\n\u001b[31;1mTime remaining: {timeRemaining} seconds");
                Console.WriteLine($"Question {i+1}: {Hardquestions[num].Hardquestion}");

                string userAnswer = userInput.Take(); // Wait for user input or timeout

                if (userAnswer == null)
                {
                    Grade7Ending(LogicBurger.endingAmmount, Ending);
                    return;
                }

                if (userAnswer.ToLower() != Hardquestions[num].answer.ToLower())
                {
                    Grade7Ending(LogicBurger.endingAmmount, Ending);
                    return;
                }
            }
        }
        // If all questions were answered correctly within the time limit
        Grade9Ending(LogicBurger.endingAmmount, Ending);
    }

    static void GetUserInput(BlockingCollection<string> userInput)
    {
        while (true)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
            userInput.Add(input);
#pragma warning restore CS8604 // Possible null reference argument.
        }
    }

//main
    public static void Main(string[] args)
    {
        string[,] SecretEnding = new string[2,5]
        {
            {"Meta", "Vaporised", "Jamming Out", "Hackerman", "True Ending"},
            {"1", "2", "3", "4", "5"}
        };
        string[,] Ending = new string[2,23]
        {
            {"Sonic Blasted", "Shot Dead by Crossley", "Cheffed Up by Nasir", "Gassed by Jenson", "Rebel", "No Burger", "Exiled", "Life Sentence", "Dementia", "Insanity", "Death by Cringe", "Get Scammed", "Stone Cold Lie", "Starvation", "Stapled", "Blown Away", "Damned Thee to an Eternity of Torment.", "Fame and Riches", "Regret", "Heart Attack", "Grade 4", "Grade 7", "Grade 9"},
            {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"}
        };

        //Grade9Ending(LogicBurger.endingAmmount, Ending);

        LogicBurger.Intro();

        EnterBurgerKing(ref LogicBurger.yes, ref LogicBurger.no, ref LogicBurger.response, ref LogicBurger.cashier, ref LogicBurger.reset, ref LogicBurger.endingAmmount, Ending, ref LogicBurger.flag, ref LogicBurger.god, ref LogicBurger.judge, ref LogicBurger.rebel, SecretEnding, ref LogicBurger.secretEndingAmmount, ref LogicBurger.person);
    }  

    //all endings
    public static void SonicBlastedEnding(string endingAmmount, string[,] Ending)
    {
        Console.Write("You decide to go to the \u001b[33mtoilet\u001b[0m");
        Console.ReadLine();
        Console.Write("because you thought waiting would be too risky.");
        Console.ReadLine();
        Console.Write("As you are walking to the \u001b[33mtoilets\u001b[0m,");
        Console.ReadLine();
        Console.Write("you notice there is a children's \u001b[33mtoilets\u001b[0m,");
        Console.ReadLine();
        Console.Write("which you thought nothing off untill you saw");
        Console.ReadLine();
        Console.Write("\u001b[33mHarry Woods\u001b[0m accting a bit dodgy around them.");
        Console.ReadLine();
        Console.Write("You ignore it and enter the male \u001b[33mtoilets\u001b[0m.");
        Console.ReadLine();
        Console.Write("You go in a cubicle and,");
        Console.ReadLine();
        Console.Write("\u001b[32;3mlet one rip.");
        Console.ReadLine();
        Console.Write("It was the loudest noise ever.\u001b[0m");
        Console.ReadLine();
        Console.Write("\u001b[31;1mIt caused a sonic boom which evicerated everting for a 200m radius.");
        Console.ReadLine();
        Console.Write("You died.\u001b[0m");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,0], LogicBurger.endingAmmount, Ending[0,0]);
        Console.ReadLine();
    }
    public static void ShotDeadByHarryCEnding(string endingAmmount, string[,] Ending)
    {
        Console.Write("You lunge for the \u001b[33mknife\u001b[0m,");
        Console.ReadLine();
        Console.Write("you grab it and go for the officer but just before you stab them,");
        Console.ReadLine();
        Console.Write("you notice they have a badge which says '\u001b[33mOfficer Crossley\u001b[0m' on.");
        Console.ReadLine();
        Console.Write("you then stab \u001b[33mOfficer Crossley\u001b[0m but they have just enough time to");
        Console.ReadLine();
        Console.Write("shoot you in the head.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,1], LogicBurger.endingAmmount, Ending[0,1]);
        Console.ReadLine();
    }
    public static void CheffedUpByNasirEnding(string endingAmmount, string[,] Ending)
    {
        Console.Write("You go punch \u001b[33mNasir\u001b[0m in the face but,");
        Console.ReadLine();
        Console.Write("he notices you and swiftly turns to face you when suddenly, \u001b[33mNasir\u001b[0m");
        Console.ReadLine();
        Console.Write("cheffs you up.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,2], LogicBurger.endingAmmount, Ending[0,2]);
        Console.ReadLine();
    }
    public static void GassedOutByJensonEnding(string endingAmmount, string[,] Ending)
    {
        Console.Write("You go punch \u001b[33mJenson\u001b[0m in the face but,");
        Console.ReadLine();
        Console.Write("he notices you and swiftly turns to face you when suddenly, \u001b[33mJenson\u001b[0m");
        Console.ReadLine();
        Console.Write("\u001b[32;3mlets one rip.\u001b[0m");
        Console.ReadLine();
        Console.Write("you died.");
        Console.ReadLine();
        Console.Write("nasir died.");
        Console.ReadLine();
        Console.Write("the sheer ammount of methane caused the global temperature to rise by 15C.");
        Console.ReadLine();
        Console.Write("billions died.");
        Console.ReadLine();
        Console.Write("jenson survived.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,3], LogicBurger.endingAmmount, Ending[0,3]);
        Console.ReadLine();
    }
    public static void RebelEnding(string endingAmmount, string[,] Ending)
    {
        Console.Write("You get");
        Console.ReadLine();
        Console.Write("\u001b[41;1mCRUSHED BY A METIORITE 'OUT OF SHEER CHANCE'\u001b[0m");
        Console.ReadLine();
        Console.Write("as you are lying on the floor you think to yourself that you deserve it.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,4], LogicBurger.endingAmmount, Ending[0,4]);
        Console.ReadLine();
    }
    public static void NoBurgerEnding(string endingAmmount, string[,] Ending)
    {
        Console.Write("You head back home but");
        Console.ReadLine();
        Console.Write("when you get there,");
        Console.ReadLine();
        Console.Write("its gone,");
        Console.ReadLine();
        Console.Write("you ask around what happened to it but");
        Console.ReadLine();
        Console.Write("the people say it was \u001b[33mblown up\u001b[0m!");
        Console.ReadLine();
        Console.Write("You live the rest of your sad life on the streets.");
        Console.ReadLine();
        Console.Write("\u001b[33mCraving\u001b[0m that \u001b[34mburger\u001b[0m you always wanted.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,5], LogicBurger.endingAmmount, Ending[0,5]);
        Console.ReadLine();
    }
    public static void ExiledEnding(string endingAmmount, string[,] Ending)
    {
        Console.Write("You leave the \u001b[34mBurger King\u001b[0m,");
        Console.ReadLine();
        Console.Write("feeling 15 years older than once you first entered.");
        Console.ReadLine();
        Console.Write("You think about where to go next...");
        Console.ReadLine();
        Console.Write("Greggs, Subway and Pizza hut cross your mind.");
        Console.ReadLine();
        Console.Write("To be continued...?");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,6], LogicBurger.endingAmmount, Ending[0,6]);
        Console.ReadLine();
    }
    public static void LifeSentenceEnding(string endingAmmount, string[,] Ending, string cashier)
    {
        Console.Write("{0}\u001b[36;3m *Dies of cringe*\u001b[0m", cashier);
        Console.ReadLine();
        Console.Write("You find yourself back in court,");
        Console.ReadLine();
        Console.Write("\u001b[33mMr.Plachciak\u001b[0m is staring you down again,");
        Console.ReadLine();
        Console.Write("there is no way you can defend yourself this time.");
        Console.ReadLine();
        Console.Write("\u001b[33mMr.Plachciak-\u001b[0m Life sentence for committing manslaugter twice!");
        Console.ReadLine();
        Console.Write("You live out the rest of your days in prison.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,7], LogicBurger.endingAmmount, Ending[0,7]);
        Console.ReadLine();
    }
    public static void DementiaEnding(string endingAmmount, string[,] Ending)
    {
        Console.Write("Because seem to not really know what you are doing,");
        Console.ReadLine();
        Console.Write("you just walk off in a straight line.");
        Console.ReadLine();
        Console.Write("as you are walkng,");
        Console.ReadLine();
        Console.Write("you strt realisng");
        Console.ReadLine();
        Console.Write("you cnt");
        Console.ReadLine();
        Console.Write("rmmber");
        Console.ReadLine();
        Console.Write("wre");
        Console.ReadLine();
        Console.Write("yu");
        Console.ReadLine();
        Console.Write("r");
        Console.ReadLine();
        Console.Write("hded");
        Console.ReadLine();
        Console.Write("or");
        Console.ReadLine();
        Console.Write("aytng");
        Console.ReadLine();
        Console.Write("t");
        Console.ReadLine();
        Console.Write("al");
        Console.ReadLine();
        for(int i = 0; i < 7; i++)
        {
            Console.Write(".");
            Console.ReadLine();
        }
        for(int i = 0; i < 7; i++)
        {
            Console.ReadLine();
        }
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,8], LogicBurger.endingAmmount, Ending[0,8]);
    }
    public static void InsanityEnding(string endingAmmount, string[,] Ending)
    {
        Console.Write("You ingore the knocking, thinking it is the police.");
        Console.ReadLine();
        Console.Write("You go back to bed without leaving the house.");
        Console.ReadLine();
        Console.Write("You very paranoid");
        Console.ReadLine();
        Console.Write("In the morning,");
        Console.ReadLine();
        Console.Write("you \u001b[33mdon't\u001b[0m get out of bed,");
        Console.ReadLine();
        Console.Write("the \u001b[33mpolice\u001b[0m are looking for you,");
        Console.ReadLine();
        Console.Write("is what you think.");
        Console.ReadLine();
        Console.Write("you never leave");
        Console.ReadLine();
        Console.Write("you're too paranoid");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,9], LogicBurger.endingAmmount, Ending[0,9]);
        Console.ReadLine();
    }
    public static void DeathByCringeEnding(string endingAmmount, string[,] Ending)
    {
        Console.Write("You lost...");
        Console.ReadLine();
        Console.Write("\u001b[36;3m*You die of cringe*\u001b[0m");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,10], LogicBurger.endingAmmount, Ending[0,10]);
        Console.ReadLine();
    }
    public static void GetScammedEnding(string endingAmmount, string[,] Ending)
    {
        Console.Write("\u001b[33mCharlie-\u001b[0m You are correct.");
        Console.ReadLine();
        Console.Write("\u001b[33mCharlie-\u001b[0m You should buy the racket now");
        Console.ReadLine();
        Console.Write("You ask how much the racket is.");
        Console.ReadLine();
        Console.Write("\u001b[33mCharlie- £420.69\u001b[0m");
        Console.ReadLine();
        Console.Write("\u001b[33mCharlie-\u001b[0m But is is worth it");
        Console.ReadLine();
        Console.Write("You offer to buy the racket");
        Console.ReadLine();
        Console.Write("\u001b[33mCharlie\u001b[0m hands to you in exchange for the money.");
        Console.ReadLine();
        Console.Write("You turn around to try the racket out but,");
        Console.ReadLine();
        Console.Write("It instantly turns to \u001b[33mdust\u001b[0m");
        Console.ReadLine();
        Console.Write("you turn around to look for \u001b[33mCharlie\u001b[0m but,");
        Console.ReadLine();
        Console.Write("he is gone.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,11], LogicBurger.endingAmmount, Ending[0,11]);
        Console.ReadLine();
    }
    public static void DeathByLieBennyEnding(string endingAmmount, string[,] Ending)
    {
        Console.WriteLine("");
        Console.Write("You open up cubicle 1 to see");
        Console.ReadLine();
        Console.Write("\u001b[33mBenny\u001b[0m sat there");
        Console.ReadLine();
        Console.Write("\u001b[33mBenny- \u001b[0m\u001b[31;1mHuntress Terun is bad.\u001b[0m");
        Console.ReadLine();
        Console.Write("you instantly died.");
        Console.ReadLine();
        Console.Write("no one has ever said a bigger lie ever.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,12], LogicBurger.endingAmmount, Ending[0,12]);
        Console.ReadLine();
    }
    public static void StarvationEnding(string endingAmmount, string[,] Ending)
    {
        Console.WriteLine("");
        Console.Write("You open up cubicle 2 to see");
        Console.ReadLine();
        Console.Write("\u001b[33mQuoc\u001b[0m sat there");
        Console.ReadLine();
        Console.Write("He starts saying really interesting things about Kirby");
        Console.ReadLine();
        Console.Write("\u001b[33mQuoc- \u001b[0mKirby started as a placeholder character but became the main one due to his charming design.");
        Console.ReadLine();
        Console.Write("\u001b[33mQuoc- \u001b[0mKirby was initially named 'Popopo' in Japan but was renamed for the international release.");
        Console.ReadLine();
        Console.Write("\u001b[33mQuoc- \u001b[0mKirby's ability to copy powers was introduced in Kirby's Adventure.");
        Console.ReadLine();
        Console.Write("\u001b[33mQuoc- \u001b[0mKirby's flying ability was inspired by a programming error.");
        Console.ReadLine();
        Console.Write("\u001b[33mQuoc- \u001b[0mKirby's design was influenced by Japanese marshmallows.");
        Console.ReadLine();
        Console.Write("\u001b[33mQuoc- \u001b[0mKirby's Dream Land was directed by Masahiro Sakurai, creator of Super Smash Bros.");
        Console.ReadLine();
        Console.Write("\u001b[33mQuoc- \u001b[0mKirby's species is officially called 'Kirby.'");
        Console.ReadLine();
        Console.Write("\u001b[33mQuoc- \u001b[0mKirby speaks in simple phrases in the anime but communicates non-verbally in games.");
        Console.ReadLine();
        Console.Write("\u001b[33mQuoc- \u001b[0mKirby's Dream Course was originally a different game called Special Tee Shot.");
        Console.ReadLine();
        Console.Write("\u001b[33mQuoc- \u001b[0mKirby has appeared in various spin-off games like puzzle and racing games.");
        Console.ReadLine();
        Console.Write("It is actually so very interesting, that you didn't notcie the time.");
        Console.ReadLine();
        Console.Write("It has been two weeks.");
        Console.ReadLine();
        Console.Write("You died");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,13], LogicBurger.endingAmmount, Ending[0,13]);
        Console.ReadLine();
    }
    public static void StapledEnding(string endingAmmount, string[,] Ending)
    {
        Console.WriteLine("");
        Console.Write("You open up cubicle 3 to see");
        Console.ReadLine();
        Console.Write("\u001b[33mDaniel\u001b[0m sat there");
        Console.ReadLine();
        Console.Write("You walk in but,");
        Console.ReadLine();
        Console.Write("the door closes behind you.");
        Console.ReadLine();
        Console.Write("\u001b[33mDaniel\u001b[0m is holding a stapler.");
        Console.ReadLine();
        Console.Write("You look at \u001b[33mDaniel's\u001b[0m hands to see nothing but metal.");
        Console.ReadLine();
        Console.Write("\u001b[33mDaniel\u001b[0m holds the stapler up to you.");
        Console.ReadLine();
        Console.Write("You get stapled.");
        Console.ReadLine();
        Console.Write("You died.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,14], LogicBurger.endingAmmount, Ending[0,14]);
        Console.ReadLine();
    }
    public static void BlownAwayEnding(string endingAmmount, string[,] Ending)
    {
        Console.WriteLine("");
        Console.Write("You open up cubicle 4 to see");
        Console.ReadLine();
        Console.Write("\u001b[33mFayaz\u001b[0m sat there");
        Console.ReadLine();
        Console.Write("\u001b[33mFayaz\u001b[0m shows you his DT NEA.");
        Console.ReadLine();
        Console.Write("It was so good that your");
        Console.ReadLine();
        Console.Write("socks blew off.");
        Console.ReadLine();
        Console.Write("They blew off so fast that,");
        Console.ReadLine();
        Console.Write("your feet came with them.");
        Console.ReadLine();
        Console.Write("You died.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,15], LogicBurger.endingAmmount, Ending[0,15]);
        Console.ReadLine();
    }
    public static void EternityOfTormentEnding(string endingAmmount, string[,] Ending)
    {
        Console.WriteLine("");
        Console.Write("[The scene opens in a dimly lit Burger King restaurant bathroom.");
        Console.ReadLine();
        Console.Write("You cautiously enter, glancing around nervously.");
        Console.ReadLine();
        Console.Write("The air is heavy with the scent of disinfectant. ");
        Console.ReadLine();
        Console.Write("In the corner, the faint sound of dripping water echoes.]");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mYou-\u001b[0m [Whispering] What beast was't then that made you break this enterprise to me?");
        Console.ReadLine();
        Console.Write("When you durst do it, then you were a man;");
        Console.ReadLine();
        Console.Write("And to be more than what you were, you would be so much more the man.");
        Console.ReadLine();
        Console.Write("[You glance around, feeling a creeping sense of unease.]");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("[\u001b[33mRudy\u001b[0m, suddenly materializes sitting in cubicle 5,");
        Console.ReadLine();
        Console.Write("his ghostly visage pale and haunting.");
        Console.ReadLine();
        Console.Write("He stares at you with accusing eyes.]");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mRudy-\u001b[0m Thou canst not say I did it; never shake thy gory locks at me.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mYou-\u001b[0m [Backing away, eyes wide with terror] Prithee,");
        Console.ReadLine();
        Console.Write("\u001b[33mRudy\u001b[0m, stop thy torment! I cannot bear it!");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mRudy-\u001b[0m Avaunt! and quit my sight! let the earth hide thee!");
        Console.ReadLine();
        Console.Write("Thy bones are marrowless, thy blood is cold;");
        Console.ReadLine();
        Console.Write("Thou hast no speculation in those eyes which thou dost glare with!");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("[You stagger backward, tripping over your own feet as you try to escape.");
        Console.ReadLine();
        Console.Write("\u001b[33mRudy's\u001b[0m ghostly laughter fills the air, sending shivers down your spine.]");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mYou-\u001b[0m [Desperately] Leave me be, foul spirit! I beg thee!");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("[\u001b[33mRudy's\u001b[0m ghostly form advances, causing you to stumble and fall to the ground.");
        Console.ReadLine();
        Console.Write("You gasp for air, clutching at your chest,");
        Console.ReadLine();
        Console.Write("feeling as if your very soul is being torn asunder.]");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mRudy-\u001b[0m [Mockingly] Fare thee well. Thou shalt never find peace,");
        Console.ReadLine();
        Console.Write("for thy treachery hath damned thee to an eternity of torment.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("[With a final agonized gasp, you collapse to the floor, lifeless.");
        Console.ReadLine();
        Console.Write("The Burger King bathroom falls into an eerie silence,");
        Console.ReadLine();
        Console.Write("save for the sound of dripping water,");
        Console.ReadLine();
        Console.Write("\u001b[33mRudy's\u001b[0m ghostly form fades away into the darkness.]");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,16], LogicBurger.endingAmmount, Ending[0,16]);
        Console.ReadLine();
    }
    public static void FameAndRichesEnding(string endingAmmount, string[,] Ending)
    {
        Console.WriteLine("");
        Console.Write("You open up cubicle 6 to see");
        Console.ReadLine();
        Console.Write("\u001b[33mA GOLDEN TOILET!\u001b[0m");
        Console.ReadLine();
        Console.Write("You must have opened a \u001b[32msafe\u001b[0m cubicle!");
        Console.ReadLine();
        Console.Write("You go to grab it but then,");
        Console.ReadLine();
        Console.Write("Little you know, the situation was about to take a dramatic turn.");
        Console.ReadLine();
        Console.Write("As the day unfolded, unforeseen obstacles emerged one after another.");
        Console.ReadLine();
        Console.Write("Just when they thought they had it all figured out, a new complication arose.");
        Console.ReadLine();
        Console.Write("Time seemed to stretch on endlessly as they waited for the inevitable outcome.");
        Console.ReadLine();
        Console.Write("With each passing moment, the tension in the room grew palpably thicker.");
        Console.ReadLine();
        Console.Write("Despite their best efforts, the solution remained elusive, slipping further away.");
        Console.ReadLine();
        Console.Write("As the minutes ticked by, uncertainty hung in the air like a heavy fog.");
        Console.ReadLine();
        Console.Write("Unexpected revelations continued to surface,");
        Console.ReadLine();
        Console.Write("casting doubt on everything they thought they knew.");
        Console.ReadLine();
        Console.Write("Every twist and turn in the story only served to deepen the mystery.");
        Console.ReadLine();
        Console.Write("In the midst of chaos, a glimmer of hope flickered faintly on the horizon.");
        Console.ReadLine();
        Console.Write("It was just a gold toilet");
        Console.ReadLine();
        Console.Write("Its a \u001b[32msafe\u001b[0m cubicle!");
        Console.ReadLine();
        Console.Write("You get the toilet and it is real 24K gold.");
        Console.ReadLine();
        Console.Write("You sell it and your life changes forever.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,17], LogicBurger.endingAmmount, Ending[0,17]);
        Console.ReadLine();
    }
    public static void RegretEnding(string endingAmmount, string[,] Ending)
    {
        Console.WriteLine("");
        Console.Write("You leave the \u001b[34mBurger King\u001b[0m.");
        Console.ReadLine();
        Console.Write("You go back home, feeling bad about what happened.");
        Console.ReadLine();
        Console.Write("`Why didn't you just go to the toilet earlier?`");
        Console.ReadLine();
        Console.Write("You thought to yourself");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,18], LogicBurger.endingAmmount, Ending[0,18]);
        Console.ReadLine();
    }
    public static void HeartAttackEnding(string endingAmmount, string[,] Ending)
    {
        Console.Write("You decide to wait it out.");
        Console.ReadLine();
        Console.Write("You relise you will have to let it out here but when suddenly,");
        Console.ReadLine();
        Console.Write("\u001b[32;3myou feel an urgent rumble in your stomach.");
        Console.ReadLine();
        Console.Write("Ignoring the warning signs, you proceed to relieve yourself,");
        Console.ReadLine();
        Console.Write("only to realize too late that the seat was not a toilet.");  
        Console.ReadLine();
        Console.Write("Panic floods your mind as you try to clean up the mess,");
        Console.ReadLine();
        Console.Write("but before you can escape the humiliation,");
        Console.ReadLine();
        Console.Write("you suffer a sudden, fatal heart attack,");
        Console.ReadLine();
        Console.Write("collapsing onto the floor in a grotesque tableau of embarrassment and demise.");
        Console.ReadLine();
        Console.Write("Your final moments are spent in a mixture of shame and disbelief,");
        Console.ReadLine();
        Console.Write("forever etched in the memories of horrified onlookers.");
        Console.ReadLine();
        Console.Write("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,19], LogicBurger.endingAmmount, Ending[0,19]);
        Console.ReadLine();
    }
    public static void Grade4Ending(string endingAmmount, string[,] Ending)
    {
        Console.WriteLine("");
        Console.Write("\u001b[33mFinlay-\u001b[0m Its jover for you.");
        Console.ReadLine();
        Console.Write("\u001b[33mFinlay-\u001b[0m Really?");
        Console.ReadLine();
        Console.Write("\u001b[33mFinlay-\u001b[0m You didnt even make it to the hard question.");
        Console.ReadLine();
        Console.Write("He pulls out a gun and,");
        Console.ReadLine();
        Console.Write("shoots you down");
        Console.ReadLine();
        Console.Write("You died.");
        Console.ReadLine();
        Console.Write("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,20], LogicBurger.endingAmmount, Ending[0,20]);
        Console.ReadLine();
    }
    public static void Grade7Ending(string endingAmmount, string[,] Ending)
    {
        Console.WriteLine("");
        Console.Write("\u001b[33mFinlay-\u001b[0m That was alright.");
        Console.ReadLine();
        Console.Write("\u001b[33mFinlay-\u001b[0m At least you made it to the last question.");
        Console.ReadLine();
        Console.Write("\u001b[33mFinlay-\u001b[0m Although you didn't win.");
        Console.ReadLine();
        Console.Write("He pulls out a gun and,");
        Console.ReadLine();
        Console.Write("shoots you down");
        Console.ReadLine();
        Console.Write("You died.");
        Console.ReadLine();
        Console.Write("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,21], LogicBurger.endingAmmount, Ending[0,21]);
        Console.ReadLine();
    }
    public static void Grade9Ending(string endingAmmount, string[,] Ending)
    {
        Console.WriteLine("");
        Console.Write("\u001b[33mFinlay-\u001b[0m Wel done.");
        Console.ReadLine();
        Console.Write("\u001b[33mFinlay-\u001b[0m That was pretty hard but,");
        Console.ReadLine();
        Console.Write("\u001b[33mFinlay-\u001b[0m I know you cheated.");
        Console.ReadLine();
        Console.Write("He pulls out a gun and,");
        Console.ReadLine();
        Console.Write("shoots you down");
        Console.ReadLine();
        Console.Write("You died.");
        Console.ReadLine();
        Console.Write("");
        Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,22], LogicBurger.endingAmmount, Ending[0,22]);
        Console.ReadLine();
    }


    // all secret endings
    public static void MetaSecretEnding(string secretEndingAmmount, string[,] SecretEnding, string cashier)
    {
        Console.ReadLine();
        Console.Write("{0}\u001b[36;3m*Stares awkwardly at you*\u001b[0m", cashier);
        for(int i = 0; i < 5; i++)
        {
            Console.ReadLine();
        }
        Console.Write("\u001b[36;3m*You can only stare back*\u001b[0m");
        for(int i = 0; i < 10; i++)
        {
            Console.ReadLine();
        }
        Console.Write("\u001b[36;3m*You start to realise something...*\u001b[0m");
        for(int i = 0; i < 10; i++)
        {
            Console.ReadLine();
        }
        Console.Write("\u001b[36;3m*You start to think that you are not acctualy in \u001b[0m\u001b[34mBurger King\u001b[36;3m*\u001b[0m");
        for(int i = 0; i < 10; i++)
        {
            Console.ReadLine();
        }
        Console.Write("\u001b[36;3m*You soon realise where you acctualy are*\u001b[0m");
        for(int i = 0; i < 10; i++)
        {
            Console.ReadLine();
        }
        Console.Write("You are in C21");
        for(int i = 0; i < 10; i++)
        {
            Console.ReadLine();
        }
        Console.Write("Mr Hoyle is behind you.");
        for(int i = 0; i < 10; i++)
        {
            Console.ReadLine();
        }
        Console.WriteLine("\u001b[35;1mSecret ending {0}/{1}: {2}\u001b[0m\n(Find more secret endings by typing something other than yes or no)", SecretEnding[1,0], secretEndingAmmount, SecretEnding[0,0]);
        Console.ReadLine();
    }
    public static void VaporisedSecretEnding(string secretEndingAmmount, string[,] SecretEnding)
    {
        Console.Write("You don't really feel like helping \u001b[33mMulberry\u001b[0m,");
        Console.ReadLine();
        Console.Write("as you don't really want to be \u001b[33mslain\u001b[0m.");
        Console.ReadLine();
        Console.Write("You walk out of the \u001b[34mBurger King\u001b[0m but,");
        Console.ReadLine();
        Console.Write("you get \u001b[33mvaporised\u001b[0m.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mSecret ending {0}/{1}: {2}\u001b[0m\n(Find more secret endings by typing something other than yes or no)", SecretEnding[1,1], secretEndingAmmount, SecretEnding[0,1]);
        Console.ReadLine();
    }
    public static void JammingOutSecretEnding(string secretEndingAmmount, string[,] SecretEnding, string cashier)
    {
        for(int i = 0; i < 3; i++)
        {
            if (i > 0)
                {
                    Console.Write("{0} Whopper, Whopper, Whopper, Whopper", cashier);
                    Console.ReadLine();
                }
            Console.Write("{0} Junior, Double, Triple Whopper", cashier);
            Console.ReadLine();
            Console.Write("{0} Flame-grilled taste with perfect toppers", cashier);
            Console.ReadLine();
            Console.Write("{0} I rule this day", cashier);
            Console.ReadLine();
            Console.Write("{0} Lettuce, mayo, pickle, ketchup", cashier);
            Console.ReadLine();
            Console.Write("{0} Itst's okay if I don't want that", cashier);
            Console.ReadLine();
            Console.Write("{0} Impossible or bacon Whopper", cashier);
            Console.ReadLine();
            Console.Write("{0} Any Whopper my way", cashier);
            Console.ReadLine();
        }
        Console.Write("{0} You rule, you're seizin' the day", cashier);
        Console.ReadLine();
        Console.Write("{0} At BK, have it your way", cashier);
        Console.ReadLine();
        Console.Write("{0} (You rule)", cashier);
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mSecret ending {0}/{1}: {2}\u001b[0m\n(Find more secret endings by typing something other than yes or no)", SecretEnding[1,2], secretEndingAmmount, SecretEnding[0,2]);
        Console.ReadLine();
    }
    public static void HackerManSecretEnding(string secretEndingAmmount, string[,] SecretEnding, string cashier)
    {
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mSecret ending {0}/{1}: {2}\u001b[0m\n(Find more secret endings by typing something other than yes or no)", SecretEnding[1,3], secretEndingAmmount, SecretEnding[0,3]);
        Console.ReadLine();
    }
    public static void TrueSecretEnding(string secretEndingAmmount, string[,] SecretEnding, string cashier)
    {
        Console.Write("Title: \u001b[34mThe Burger King\u001b[0m Temptation: You to Commit Regicide");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("[The scene opens in a Burger King restaurant late at night. You are seated at a booth, visibly distressed.");
        Console.ReadLine();
        Console.Write("\u001b[33mMulberry\u001b[0m approaches, dressed in a Burger King uniform.]");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mMulberry-\u001b[0m [leaning in, speaking urgently] Why do you sit alone, lost in thought,");
        Console.ReadLine();
        Console.Write("when opportunity knocks as loudly as the flame-grilled scent of our Whoppers?");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mYou-\u001b[0m [wearily] Oh, \u001b[33mMulberry\u001b[0m, I am torn within.");
        Console.ReadLine();
        Console.Write("\u001b[34mThe Burger King\u001b[0m, our gracious host has been so kind to us, and yet... ");
        Console.ReadLine();
        Console.Write("I cannot shake these dark thoughts that plague my mind.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mMulberry-\u001b[0m [leaning closer, his voice low and insistent] Kindness, is but a facade, like the paper crown upon his head.");
        Console.ReadLine();
        Console.Write("Beneath that cheerful exterior lies ambition, an ambition that would see you cast aside, forgotten,");
        Console.ReadLine();
        Console.Write("while he sits atop his throne of fries and shakes.");
        Console.ReadLine();
        Console.Write("Think of it, think of what could be yours if you but reach out and seize it.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mYou-\u001b[0m [hesitant] But to take such a step, to betray the trust of \u001b[34mThe Burger King\u001b[0m, ");
        Console.ReadLine();
        Console.Write("it goes against all that I hold sir.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mMulberry-\u001b[0m [eyes gleaming with determination] What is loyalty but a chain that binds us to the whims of others?");
        Console.ReadLine();
        Console.Write("Break free from those shackles and claim your destiny! ");
        Console.ReadLine();
        Console.Write("\u001b[34mThe Burger King\u001b[0m's crown is not his by right, but by the mere chance of fate.");
        Console.ReadLine();
        Console.Write("Are you content to let fate decide your future, ");
        Console.ReadLine();
        Console.Write("or will you grasp it with both hands and forge your own path?");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mYou-\u001b[0m [contemplative, yet conflicted] But what of the consequences, \u001b[33mMulberry\u001b[0m?");
        Console.ReadLine();
        Console.Write("What of the blood that would stain my hands?");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mMulberry-\u001b[0m [with a dismissive wave] Consequences are but the whispers of the weak.");
        Console.ReadLine();
        Console.Write("Do not let fear hold you back from greatness.");
        Console.ReadLine();
        Console.Write("Remember, fortune favors the bold, and in boldness lies the key to power.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mYou-\u001b[0m [slowly nodding, conviction growing in your eyes] You speak the truth, \u001b[33mMulberry\u001b[0m. ");
        Console.ReadLine();
        Console.Write("I shall not falter in the face of adversity.");
        Console.ReadLine();
        Console.Write("Tonight, I shall do what must be done.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mMulberry-\u001b[0m [smirking triumphantly] Embrace the darkness, and let it guide you to glory.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("[You rise from your seat, determination etched upon your face,");
        Console.ReadLine();
        Console.Write("as \u001b[33mMulberry\u001b[0m watches with satisfaction.]");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mYou-\u001b[0m [firmly] Tonight, \u001b[34mThe Burger King\u001b[0m shall fall, and I shall rise in his place.");
        Console.ReadLine();
        Console.Write("Thank you, \u001b[33mMulberry\u001b[0m, for showing me the path to greatness.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mMulberry-\u001b[0m [smiling wickedly] Go now, and claim your destiny.");
        Console.ReadLine();
        Console.Write("\u001b[34mThe Burger King\u001b[0m's crown awaits its rightful heir.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("[You exit \u001b[34mThe Burger King\u001b[0m restaurant, resolved to carry out the dark deed that lies ahead,");
        Console.ReadLine();
        Console.Write("leaving \u001b[33mMulberry\u001b[0m to revel in his manipulation.]");
        Console.ReadLine();
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("Title: You at Burger King: The \u001b[34mWhopper\u001b[0m Murder");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("[The scene opens in a Burger King restaurant late at night.");
        Console.ReadLine();
        Console.Write("You are pacing nervously. \u001b[34mThe Burger King\u001b[0m sits at a table, enjoying a \u001b[34mWhopper\u001b[0m.]");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mYou-\u001b[0m [to yourself] Is this a \u001b[34mWhopper\u001b[0m which I see before me,");
        Console.ReadLine();
        Console.Write("The beefy patty toward my hand?");
        Console.ReadLine();
        Console.Write("Come, let me clutch thee.");
        Console.ReadLine();
        Console.Write("I have thee not, and yet I see thee still, Art thou not,");
        Console.ReadLine();
        Console.Write("fatal sandwich, sensible o feeling as to sight?");
        Console.ReadLine();
        Console.Write("or art thou but a sandwich of the mind, a false creation,");
        Console.ReadLine();
        Console.Write("Proceeding from the heat-oppressed brain?");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("[You approach \u001b[34mThe Burger King\u001b[0m with trepidation.]");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mYou-\u001b[0m Hail to thee, Burger King! Hail to thee, thou art as delicious as thou art fulfilling!");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("[As \u001b[34mThe Burger King\u001b[0m takes a hearty bite,");
        Console.ReadLine();
        Console.Write("you seize the moment and grab the \u001b[34mWhopper\u001b[0m, your hands trembling.]");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mYou-\u001b[0m Art thou not, fatal \u001b[34mWhopper\u001b[0m, sensible to feeling as to taste?");
        Console.ReadLine();
        Console.Write("or art thou but a sandwich of the mind,");
        Console.ReadLine();
        Console.Write("a false creation, proceeding from the hunger within me?");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("[As \u001b[34mThe Burger King\u001b[0m takes a hearty bite,");
        Console.ReadLine();
        Console.Write("you seize the moment and grab the \u001b[34mWhopper\u001b[0m, your hands trembling.]");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("[With a sudden surge of resolve, you lunge at \u001b[34mThe Burger King\u001b[0m with the \u001b[34mWhopper\u001b[0m,");
        Console.ReadLine();
        Console.Write("striking him with force. \u001b[34mThe Burger King\u001b[0m slumps over, lifeless.]");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("\u001b[33mYou-\u001b[0m [breathless, horrified] What have I done?");
        Console.ReadLine();
        Console.Write("The deed is done, and \u001b[34mThe Burger King\u001b[0m is no more. Oh, woe is me!");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\u001b[35;1mSecret ending {0}/{1}: {2}\u001b[0m\n(Find more secret endings by typing something other than yes or no)", SecretEnding[1,4], secretEndingAmmount, SecretEnding[0,4]);
        Console.ReadLine();
    }
}

//\u001b[0m- reset colour
//https://ansi.gabebanks.net/ -colour picker
//all colours start with \u001b

public class LogicBurger
{
    public static string person = "";
    public static string cashier = "\u001b[33mCashier-\u001b[0m";
    public static string god = "\u001b[33mGod- \u001b[0m";
    public static string judge = "\u001b[33mJudge-\u001b[0m";

    public static string endingAmmount = "23"; 
    public static string secretEndingAmmount = "5";
    public static bool flag = false;
    public static bool yes = false;
    public static bool no = false;
    public static string response = "";
    public static bool reset = false;
    public static bool rebel = true;

     
    public static void Templates()
    {
        //template for responding if statement:
        /*
        do
        {
            LogicBurger.flag = false;
            Console.WriteLine("[question here]");
            LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
            if(yes == true && reset == false)
            {
                
            }
            else if(no == true && reset == false)
            {
                
            }
            else if (reset == false)
            {
                Console.WriteLine("{0}What is bro waffling about, do that again", god);
                Console.ReadLine();
                LogicBurger.flag = true;
            }
            reset = true;
        }
        while(LogicBurger.flag == true);
        */

        //template for end line
        //Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,0], LogicBurger.endingAmmount, Ending[0,0]);
        
    }

    public static void Intro()
    {
        Console.WriteLine("");
        Console.WriteLine("\u001b[34;4mBurger King Siulator\u001b[0m");
        Console.WriteLine("");
        Console.WriteLine("Type \u001b[32my\u001b[0m for \u001b[32mYes\u001b[0m, \u001b[31mn\u001b[0m for \u001b[31mNo\u001b[0m or anything else that might be relevant in responsces");
        Console.WriteLine("Type r to Reset");
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
    }

    public static void Respond(ref bool yes, ref bool no, ref string response, ref string cashier, ref bool reset, ref string endingAmmount, string[,] Ending, ref bool flag, ref string god, ref string judge, ref bool rebel, string[,] SecretEnding, ref string secretEndingAmmount, ref string person)
    {
        yes = false;
        no = false;
        response = "";
        reset = false;
#pragma warning disable CS8601 // Possible null reference assignment.
        response = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
        

        if (response == "y" || response == "yes" || response == "Y" || response == "Yes")
        {
            yes = true;
            reset = false;
            Console.WriteLine("");
        }
        else if (response == "n" || response == "no" || response == "N" || response == "No" )
        {
            no = true;
            reset = false;
            Console.WriteLine("");
        }
        else if (response == "r" || response == "reset" || response == "R" || response == "Reset")
        {
            VarReset(ref yes, ref no, ref response, ref reset, ref cashier, ref god);
            reset = true;
            MainBurger.EnterBurgerKing(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
        }
    }

    public static void VarReset(ref bool yes, ref bool no, ref string response, ref bool reset, ref string chashire, ref string god)
    {
        yes = false;
        no = false;
        response = "";
        reset = false;
        cashier = "\u001b[33mCashier-\u001b[0m";
        god = "\u001b[33mGod-\u001b[0m";
        rebel = true;
    }
}
