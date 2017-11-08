using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class ContaBancaria
    {
        private string m_nomeCorrentista;

        private double m_saldo;

        private bool m_bloqueio = false;

        private ContaBancaria()
        {
        }

        public ContaBancaria(string nomeCorrentista, double saldo)
        {
            m_nomeCorrentista = nomeCorrentista;
            m_saldo = saldo;
        }

        public string NomeCorrentista
        {
            get { return m_nomeCorrentista; }
        }

        public double Saldo
        {
            get { return m_saldo; }
        }

        public void Debito(double montante)
        {
            if (m_bloqueio)
            {
                throw new Exception("Conta bloqueada");
            }

            if (montante > m_saldo)
            {
                throw new ArgumentOutOfRangeException("montante");
            }

            if (montante < 0)
            {
                throw new ArgumentOutOfRangeException("montante");
            }

            m_saldo -= montante; // inserido erro de codigo  
        }

        public void Credito(double montante)
        {
            if (m_bloqueio)
            {
                throw new Exception("Conta bloqueada");
            }

            if (montante < 0)
            {
                throw new ArgumentOutOfRangeException("montante");
            }

            m_saldo += montante;
        }

        public void BloquearConta()
        {
            m_bloqueio = true;
        }

        public void DesbloqueiaConta()
        {
            m_bloqueio = false;
        }
    }
}
