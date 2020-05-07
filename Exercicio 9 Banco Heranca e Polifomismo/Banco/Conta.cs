﻿using System;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; internal set; }
        public double Saldo { get;protected  set; }
        internal Cliente Titular { get; set; }

        public Conta()
        {

        }
        public virtual void Deposita(double valorOperacao)
        {
             
            this.Saldo += valorOperacao;
        }

      public virtual void Saca(double valorOperacao)
        {
            this.Saldo -= valorOperacao;
        }
    }
}