using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero.Clases
{
    internal class CLS_Cliente
    {

        string Nombre;
        string Cuenta;
        int Pin;
        double Saldo;

        public CLS_Cliente()
        {

            Nombre = "";
            Cuenta = "";
            Pin = 0;
            Saldo = 0;

        }

            public CLS_Cliente(string nom, string cuent, int pin, double sal) { 
            
                Nombre = nom;
                Cuenta = cuent;
                Pin = pin;  
                Saldo = sal;
            
            
            
            }

        public void establecerNombre(string nom) {

            Nombre = nom;

        }

        public string obtenerNombre()
        {

            return Nombre;

        }

        public void establecerCuenta(string cuent)
        {

            Cuenta = cuent;

        }

        public string establecerNombre()
        {

            return Cuenta;

        }

        public void establecerPIN(int pin) {

            Pin = pin;
        
        }

        public int obtenerPIN() { 
        
            return Pin;

        }

        public void establecerSaldo(double sal) {

            Saldo = sal;
        
        }

        public double obtenerSaldo() { 
        
            return Saldo;
        
        }

        if (Saldo > monto){
            
            

            }else{
            
            
            }

    }
    }


    

