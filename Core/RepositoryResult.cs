using System;
using System.Collections.Generic;

namespace xmedicalehr.api.Core
{
    public class RepositoryResult
    {
        public List<string> Errors { get; set; }
        public List<string> Warnings { get; set; }
        public string Data { get; set; }
        public bool Suscceed
        {
            get
            {
                return Errors.Count == 0;
            }
        }

        public RepositoryResult()
        {
            Errors = new List<string>();
            Warnings = new List<string>();
        }

        public override string ToString()
        {
            return String.Join(' ', Errors);
        }
    }
}