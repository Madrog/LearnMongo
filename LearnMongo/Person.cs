using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Entities.Core;

namespace LearnMongo
{
    class Person : Entity
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int SiblingCount { get; set; }
    }
}
