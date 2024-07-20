namespace demo_oop_4
{

    class program
    {

        public static void print10numbersfromseries(Iseries series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                { 
                Console.WriteLine(series.current);
                    series.getnext();
                
                }
                series.reset(); 
            
            
            }
        }
        static void main(string[] args)
        {

            #region interface
          //  Imytype mytype= new Imytype();  //invalid
            //You Can not Create an object from interface

           // Imytype mytype
                //you can create a reference from interface

                mytype mytype1 = new mytype();
            mytype1.Id = 30;
            mytype1.myfun(100);


            Imytype mytype = new mytype();
            mytype.Id = 68;
            mytype.myfun(4532);
            mytype.print();


            #endregion
            #region interface ex01
            //seriesbytwo Seriesbytwo = new seriesbytwo();
            //print10numbersfromseries(Seriesbytwo);

            //seriesbythree Seriesbythree = new seriesbythree();
            //print10numbersfromseries(Seriesbythree);

            #endregion

        }



    }

}