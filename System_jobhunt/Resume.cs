using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace System_jobhunt
{
    public enum Job
    {
        Engineer,
        Teacher,
        Lawyer,
        Driver,
        Doctor,
        Architect
    }

    internal class Resume
    {
        private int _mark;
        private Job _job;
        private Human _human;

        private Human Names
        {
            get => _human;
        }
        public string HumanName
        {
            get { return Names != null ? Names.Name : "Не назначено"; }
        }
        public int Mark
        {
            get => _mark;
        }

        public Job Job
        {
            get => _job;
        }

        public Resume(int mark, Job job, Human human)
        {
            _mark = mark;
            _job = job;
            _human = human;
        }


    }
}
