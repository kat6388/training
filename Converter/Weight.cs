using System;
namespace Converter
{
    class Weight
    {
        //Pnd
        public double FromPndToGr(double Pnd)
        {
            double Gr = Pnd * 453.592;
            return Gr;
        }
        public double FromPndToPd(double Pnd)
        {
            double Pd = Pnd / 36.113 ;
            return Pd;
        }
        //Gr
        public double FromGrToPnd(double Gr)
        {
            double Pnd = Gr / 453.592;
            return Pnd;
        }
        public double FromGrToPd(double Gr)
        {
            double Pd = Gr/ 16380.687;
            return Pd;
        }
        //Pd
        public double FromPdToGr(double Pd)
        {
            double Gr = Pd * 16380.687;
            return Gr;
        }
        public double FromPdToPnd(double Pd)
        {
            double Pnd = Pd * 36.113;
            return Pnd;
        }
    }
}
