﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KinoBileti.Services.Interface
{
    public interface IBackgroundEmailSender
    {
        Task DoWork();
    }
}