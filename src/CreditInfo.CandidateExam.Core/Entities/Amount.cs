﻿using CreditInfo.CandidateExam.Core.Enums;

using Microsoft.EntityFrameworkCore;

namespace CreditInfo.CandidateExam.Core.Entities
{
    public class Amount
    {
        public decimal Value { get; set; }

        public Currency Currency { get; set; }
    }
}
