using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class ClassRoom
    {
        private Pupil _student1;
        private Pupil _student2;
        private Pupil _student3;

        public ClassRoom(Pupil _STUDENT1, Pupil _STUDENT2)
        {
            _student1 = _STUDENT1;
            _student2 = _STUDENT2;
        }
        public ClassRoom(Pupil _STUDENT1, Pupil _STUDENT2, Pupil _STUDENT3)
            : this(_STUDENT1, _STUDENT2)
        {
            _student3 = _STUDENT3;
        }
    }
}
    
