﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public long HiddenId { get; set; }
    }
}