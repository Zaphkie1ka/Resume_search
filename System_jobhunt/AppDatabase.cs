using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_jobhunt
{
    class AppDatabase
    {
        private Random _random = new Random();
        private int Random
        {
            get => _random.Next(0, 10);
        }
        internal List<Resume> Resumes { get; private set; }

        public void Initialize()
        {
            Resumes = new List<Resume>
            {
                new Resume(Random, Job.Architect, new Human("Виталий Л.")),
                new Resume(Random, Job.Driver, new Human("Михаил Ш.")),
                new Resume(Random, Job.Engineer, new Human("Владимир Д.")),
                new Resume(Random, Job.Teacher, new Human("Никита В.")),
                new Resume(Random, Job.Engineer, new Human("Марина Ж")),
                new Resume(Random, Job.Lawyer, new Human("Дарина П")),
                new Resume(Random, Job.Teacher, new Human("Кристина И.")),
                new Resume(Random, Job.Engineer, new Human("Николай П.")),
                new Resume(Random, Job.Architect, new Human("Полина Ц."))
            };
        }
    }
}
