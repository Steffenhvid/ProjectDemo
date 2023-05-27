using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bp.Application.Interfaces
{
    public interface IUseCase<TInput,TOutput>
    {
        public TOutput execute(TInput input);
    }

    public interface IUseCase<TInput>
    {
        public void execute(TInput input);
    }
}
