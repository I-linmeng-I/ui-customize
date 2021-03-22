using NLua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ui自定义工具
{
    class FunctionClass
    {
        //解析lua
        public void GetLuaInfo()
        {
            Lua lua = new Lua();

            lua.DoFile(@"D:\源码\repos\ui自定义工具\ui自定义工具\bin\Debug\test.lua");

            lua.RegisterFunction("XCreateWindow",);

            LuaFunction func = lua.GetFunction("test");

            func.Call();

            
        }
        private void creatwindow(string parentid,int l,int t,int w,int h)
        {

        }
    }
}
