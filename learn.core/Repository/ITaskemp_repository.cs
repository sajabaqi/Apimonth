﻿using learn.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace learn.core.Repository
{
    public interface ITaskemp_repository
    {
        public List<Taskemp_api> getalltaskemp();
        public bool updatetaskemp(Taskemp_api taskemp);
        public bool deletetaskemp(int id);
        public bool inserttaskemp(Taskemp_api taskemp);
        public Taskemp_api getbyidtaskemp(int id);
    }
}
