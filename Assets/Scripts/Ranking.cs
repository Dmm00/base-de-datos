using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Ranking : IComparable<Ranking>
{
    //Las 4 propiedades que tendrá el ranking
    public int ID { get; set; }
    public int Puntos { get; set; }
    public DateTime Fecha { get; set; }
    public string Nombre { get; set; }
    
    

    public Ranking(int ID,int Puntos, DateTime Fecha,string Nombre)
    {
        this.ID = ID;
        this.Puntos = Puntos;
        this.Fecha = Fecha;
        this.Nombre = Nombre;
    }

    public int CompareTo(Ranking other)
    {
        //return this.Score.CompareTo(other.Score);

        //el que recibe > que el que tiene = -1
        //el que recibe < que el que tiene = 1
        //0
        if (other.Puntos > this.Puntos)
        {
            return 1;
        }
        else if (other.Puntos < this.Puntos)
        {
            return -1;
        }
        else if (other.Fecha > this.Fecha)
        {
            return -1;
        }
        else if (other.Fecha < this.Fecha)
        {
            return 1;
        }
        return 0;

        //return other.Score.CompareTo(this.Score);
    }
}
