using System;

namespace Utn.FirmaDigital.Backend.Common
{
    public class Enum
    {
        public enum Operation
        {
            Save,
            List,
            Get,
            Delete,
            SaveGet
        }

        public enum Status
        {
            Success,
            Failed
        }

    }

}