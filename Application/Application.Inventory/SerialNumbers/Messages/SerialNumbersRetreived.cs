﻿using Demo.Library.Queries;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Inventory.SerialNumbers.Messages
{
    public class SerialNumbersRetreived : IMessage
    {
        public IEnumerable<SerialNumber> SerialNumbers { get; set; }
    }
}