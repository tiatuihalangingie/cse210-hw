using System;


public class Resume
{

    public string _myResume;

        public string _name;

        public List<Job> _jobs = new List<Job>();

        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs");
            
            // Using the data type "Job" in this loop
            foreach (Job job in _jobs)
            {
                job.Display();
            }
            
        
        }

}