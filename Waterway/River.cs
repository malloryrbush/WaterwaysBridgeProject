using System;

namespace Waterway
{
    class River
    {
        //DECLARE FIELDS
        private string name;
        private int depth;
        private int pollution;
        private int pollLevel;
        private int depthLevel;
        private string drainResp;
        private string pollResp;
        private int drainRiver;
        private int pollClean;
        //END DECLARE FIELDS

        //DECLARE PROPERTIES
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Depth
        {
            get { return this.depth; }
            set { this.depth = value; }
        }

        public int Pollution
        {
            get { return this.pollution; }
            set { this.pollution = value; }
        }

        public int PollLevel
        {
            get { return this.pollLevel; }
            set { this.pollLevel = value; }
        }

        public int DepthLevel
        {
            get { return this.depthLevel; }
            set { this.depthLevel = value; }
        }

        public string DrainResp
        {
            get { return this.drainResp; }
            set { this.drainResp = value; }
        }

        private int DrainRiver
        {
            get { return this.drainRiver; }
            set { this.drainRiver = value; }
        }

        public string PollResp
        {
            get { return this.pollResp; }
            set { this.pollResp = value; }
        }

        private int PollClean
        {
            get { return this.pollClean; }
            set { this.pollClean = value; }
        }
        //END DECLARE PROPERTY

        //CONSTRUCTORS
        public River()
        {
            //DEFAULT CONSTRUCTOR
        }

        //LOADED CONSTRUCTOR 
        public River(string name, int depth, int pollution)
        {
            this.name = name;
            this.depth = depth;
            this.pollution = pollution;
        }

        public void GetStatus()
        {
            //POLLUTION LEVEL
            Random r = new Random();
            PollLevel = ((r.Next(1, 101) + (PollLevel)));
            Console.WriteLine("Current Pollution Level is: " + PollLevel);
            if ((PollLevel >= 30))
            {
                Console.WriteLine("River is above recommended pollution level. Would you like to clean it?");
                pollResp = Console.ReadLine().ToLower();
            }

            if (pollResp == "yes")
            {
                Console.WriteLine("Enter desired pollution level percentage out of 100.");
                pollClean = int.Parse(Console.ReadLine());

                while ((pollClean < 0 || pollClean > 100))
                {
                    Console.WriteLine("Please enter a valid number 1-100.");
                    pollClean = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Your river will catch fire.");
            }

            //DEPTH LEVEL
            Random s = new Random();
                DepthLevel = ((s.Next(5, 75) + (depth)));
                Console.WriteLine("Current Depth Level is: " + (s.Next(5, 75) + (depth)));
                while ((depthLevel >= 50))
                {
                    Console.WriteLine("River is too high. Would you like to drain it?");
                    drainResp = Console.ReadLine().ToLower(); break;
                }

                if (drainResp == "yes")
                {
                    Console.WriteLine("How low would you like to drain the river? Enter a number 5-75. 5 = almost empty. 75 = overflowing.");
                    drainRiver = int.Parse(Console.ReadLine());

                    while ((drainRiver < 5 || drainRiver > 75))//VALIDATE THAT NUMBER INPUT IS WITHIN RANGE WHILE LOOP
                    {
                        Console.WriteLine("Please enter a value above 5 or below 75.");
                        drainRiver = int.Parse(Console.ReadLine());

                        break;
                    }
               
                } //END DEPTH LEVEL
              
                else
                {
                    Console.WriteLine("Your river will overflow.");
                }

       
        }
    }
}