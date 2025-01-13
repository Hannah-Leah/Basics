namespace textAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 0;

            while (i == 0)
            {

                Console.WriteLine("There are 3 doors in front of you. There is a serial killer hiding behind one of the doors. You need to find an exit. The door on the left says \"path to exit\", the door in the middle has a lock, and the door on the right has a small blood stain. Which one do you choose? (input left, middle or right!) \n ");
                string door = Convert.ToString(Console.ReadLine());

                if (door == "left")
                {
                    Console.WriteLine("You open the door on the left and run towards the exit. The lights suddenly go out and you're in complete darkness. You hear the laughter of a strange man. You were tricked. \n ");

                }

                if (door == "middle")
                {
                    Console.WriteLine("You go for the door in the middle and try to open it, but there is a lock on it. You try to smash the lock, but it's too sturdy. Suddenly you hear a laughter behind you. It's too late now. \n "); 
                }

                if (door == "right")
                {
                    Console.WriteLine("The blood stain on the door is worrisome, but you see it as the right choice. You open the door. Nobody is there. It's time to make your next move. \n");
                    break;
                }

            }

            int a = 0;
            while (a == 0)
            {

                Console.WriteLine("You chose the right room. Now, you need to find an item to defend yourself. You have a metal box, a baseball bat and a gun. Which one do you choose? (Input metalbox, baseballbat or gun!) ");
                string tool = Convert.ToString(Console.ReadLine());

                if (tool == "metalbox")
                {
                    Console.WriteLine("You hear the laughter of a strange man coming towards you. You quickly pick up the metal box on the ground. Suddenly a man with a knife comes rushing into you. You throw the metal box at him which makes him fall down and scream in pain. You start running away. \n");
                    break;
                }

                if (tool == "baseballbat")
                {
                    Console.WriteLine("You hear the laughter of a strange man coming towards you. you pick up the baseball bat. Suddenly a man with a knife comes rushing into you. You use the baseball bat to fight him off. You managed to throw the killer on the ground and quickly run away. \n ");
                    break;
                }

                if (tool == "gun")
                {
                    Console.WriteLine("You pick up the gun on the desk. Suddenly you hear the laughter of a strange man coming towards you. You shoot at the killer, but realize that the gun has no bullets. The killer attacks you with a knife. You're dead. \n ");
                }
            }

            Console.WriteLine("You found the escape room. you survived!");
            Console.ReadLine();
        }
    }
}
