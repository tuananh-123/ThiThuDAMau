using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PRL.views
{
    public interface IMainView
    {
        //int Id { get; set; }
        string SearchValue { get; set; }

        event EventHandler ShowData;
        event EventHandler SearchData;

        void SetBindingSource(BindingSource petLists);
        void Show();

    }
}
