/*------------------------------------------------------------------------------
 *                      HTBLA-Leonding / Class: 3ACIF                           
 *------------------------------------------------------------------------------
 *                      Jan Ritt                                                
 *------------------------------------------------------------------------------
 *  Description:  The program guesses your charakter
 *------------------------------------------------------------------------------
*/
using System;
using System.Text;
using System.Threading;

namespace DonaldAndFriends
{
  class Program
  {
    static void Main()
    {
      bool abort, fail;
      char choice;

      /*  INTRODUCTION  */
      Console.Clear();

      Console.Write("" +
        "██████████████████████████████████████████████████▀██\r\n" +
        "██▄ ▄▄▀█▄ ██ ▄█ ▄▄▄ █▄ █ ▄█▄ ▄ ▀█▄ ██ ▄█▄ ▄▄▀█ ▄▄▄▄██\r\n" +
        "███ ██ ██ ██ ██ ███▀██ ▄▀███ ▄ ▀██ ██ ███ ▄ ▄█ ██▄ ██\r\n" +
        "█▀▄▄▄▄▀▀▀▄▄▄▄▀▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▀▀▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▄▀█\r\n" +
        "█████████████████████████████████████████████████████\r\n" +
        "█▄ ▄▄▀█▄ ▄▄ █ ▄ ▄ █▄ ▄▄ █ ▄▄▄ █ ▄ ▄ █▄ ▄█▄ █ ▄█▄ ▄▄ █\r\n" +
        "██ ██ ██ ▄█▀███ ████ ▄█▀█ ███▀███ ████ ███▄▀▄███ ▄█▀█\r\n" +
        "▀▄▄▄▄▀▀▄▄▄▄▄▀▀▄▄▄▀▀▄▄▄▄▄▀▄▄▄▄▄▀▀▄▄▄▀▀▄▄▄▀▀▀▄▀▀▀▄▄▄▄▄▀");
      /// wait a moment
      Thread.Sleep(100);
      //     Console.Clear();
      ///  HEADER 
      Console.Write("\n═════════════════════════════════════════════════════" +
             ///  INRTODUCTION
             "\n ┌──────────────────────────────┐" +
             "\n │ In Entenhausen wohnen:       │" +
             "\n │   [ Goofy ]                  │" +
             "\n │   [ Donald Duck ]            │" +
             "\n │   [ Dagobert Duck ]          │" +
             "\n │   [ Tick, Trick & Track ]    │" +
             "\n │   [ Mickey Mouse ]           │" +
             "\n ├──────────────────────────────┤" +
             "\n │ ► Einer davon bist du!       │" +
             "\n ├──────────────────────────────┤" +
             "\n │ Soll das Programm versuchen  │" +
             "\n │ zu eraten, welcher Bewohner  │" +
             "\n │ Entenhausens du bist?  ┌─────┘" +
             "\n │     [y]    /    [n]    │ → ");
      choice = Console.ReadKey().KeyChar;
      Console.Write("\n ├────────────────────────┴─────┐\n");
      ///  PLAY / ABORT choice 
      if (char.ToUpper(choice) == 'Y')
      {
        fail = false; abort = false;
        Console.Write(" │ ► Spielen  gewählt           │");
        Console.Write("\n └──────────────────────────────┘");
      }
      else if (char.ToUpper(choice) == 'N')
      {
        Console.Write(" │ ► Abbrechen gewählt          │\n");
        fail = false; abort = true;
      }
      else
      {
        fail = true; abort = true;
      }
      /// wait a moment
      Thread.Sleep(500);

      /*  GAME  */
      /// PLAY GAME
      if ((fail == false) && (abort == false))
      {
        Console.Clear();
        ///  HEADER 
        Console.Write("\n  ► Spielen  gewählt " +
                     "\n══════════════════════════════════" +
                     "\n ┌──────────────────────────────┐" +
                     "\n │ Bist du ein Hund?      ┌─────┘" +
                     "\n │     [y]    /    [n]    │ → ");
        /// dog = goofy
        choice = Console.ReadKey().KeyChar;
        Console.Write("\n ├────────────────────────┴─────┐\n");

        if (char.ToUpper(choice) == 'Y')
        {
          Console.Write(" │ Du bist Goofy !              │\n");
          fail = false; abort = true;
        }
        else if (char.ToUpper(choice) == 'N')
        {
          Console.Write(" │ Bist du eine Maus?     ┌─────┘" +
                       "\n │     [y]    /    [n]    │ → ");
          /// mouse = mickey
          choice = Console.ReadKey().KeyChar;
          Console.Write("\n ├────────────────────────┴─────┐\n");

          if (char.ToUpper(choice) == 'Y')
          {
            Console.Write(" │ Du bist Mickey Maus!         │\n");
            fail = false; abort = true;
          }
          else if (char.ToUpper(choice) == 'N')
          {
            Console.Write(" │ Bst du jung?           ┌─────┘" +
                         "\n │     [y]    /    [n]    │ → ");
            /// young = tick, trick, track
            choice = Console.ReadKey().KeyChar;
            Console.Write("\n ├────────────────────────┴─────┐\n");

            if (char.ToUpper(choice) == 'Y')
            {
              Console.Write(" │ Ihr seid Tick, Trick         │" +
                           "\n │    und Track !               │\n");
              fail = false; abort = true;
            }
            else if (char.ToUpper(choice) == 'N')
            {
              Console.Write(" │ Bist du reich?         ┌─────┘" +
                           "\n │     [y]    /    [n]    │ → ");
              /// rich = dagobert
              choice = Console.ReadKey().KeyChar;
              Console.Write("\n ├────────────────────────┴─────┐\n");

              if (char.ToUpper(choice) == 'Y')
              {
                Console.Write(" │ Du bist Dagobert Duck!       │\n");
                fail = false; abort = true;
              }
              /// no one left = donald
              else if (char.ToUpper(choice) == 'N')
              {
                Console.Write(" │ Du bist Donald Duck!         │\n");
                fail = false; abort = true;
              }
              else
              { fail = true; abort = true; }
            }
            else
            { fail = true; abort = true; }
          }
          else
          { fail = true; abort = true; }
        }

        else
        { fail = true; abort = true; }
      }


      /*  END OF PROGRAM  */
      ///  ABORT
      if ((fail == true) && (abort == true))
      {
        Console.Write(" │ ► ! Ungültige Eingabe !      │");
      }
      ///  FOUND USER
      else if ((fail == false) && (abort == true))
      {
        Console.Write(" │ ► Ende !                     │");
      }
      ///  NONE
      else if ((fail == false) && (abort == false))
      {
      }

      ///  closing line
      Console.Write("\n └──────────────────────────────┘");
      /// wait a moment
      Thread.Sleep(500);
      ///  EXIT PROMPT
      Console.Write("\n══════════════════════════════════" +
                     "\n Beenden mit beliebiger Taste ...  ");
      Console.ReadKey();
      Console.Clear();


    }
  }
}
