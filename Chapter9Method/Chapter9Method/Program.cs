using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial
{
    class Polynomial
    {
        int MAXexponential;
        int[] Elements;
      Polynomial  Polumonial(Polynomial a,int MAX){
            a.MAXexponential=MAX;
            a.Elements = new int[MAX];
            return a;
        }
        public void SetElements(){
            for(int i=0;i<Elements.Length;i++){
                Elements[i] = int.Parse(Console.ReadLine());

            }
        }
            String toString(){
                String result ="";
                for(int i=0;i<MAXexponential;i++){
                    result+=" + "+Elements[i]+"x^"+i;
                }
                return result;
            }
        }
        
    }

