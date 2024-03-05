using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; } //IResul interface den farklı olarak bir data tutması lazımdı. T vermemizin nedeni de
                        //gelecek olan datanın ne olcağını bilemeyeceğimiz için ve sadece get dememizin nedeni
                        //sadece okumamız gerektiği için
    }
}
