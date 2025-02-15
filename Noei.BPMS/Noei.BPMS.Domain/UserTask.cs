﻿namespace Noei.BPMS.Domain
{
    public class UserTask : BPMNElement
    {
        public UserTask(string name) : base(name)
        {

        }

        public string Assignee { get; set; }

        public void Complete()
        {
            Console.WriteLine($"User Task '{Name}' completed by: {Assignee}");
        }
    }
}
