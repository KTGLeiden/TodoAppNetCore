﻿
using System;

namespace TodoApp.Domain
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Finished { get; set; }
        public DateTime? FinishedTime { get; set; }
        public DateTime? DueTime { get; set; }
    }
}
