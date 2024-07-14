
using System;
using System.Diagnostics;

namespace FullStackStarter
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string command = "cd .. && cd .. && cd .. && cd .. && cd .. && cd .. && mkdir newTS && cd newTS && code . && mkdir backend && echo. > .gitignore && npx create-react-app client --template typescript && cd client && npm install -D tailwindcss postcss autoprefixer && npx tailwindcss init -p && npm i axios && echo. > .gitignore && cd src && mkdir components && mkdir pages && cd pages && echo. > Home.tsx && cd .. && cd .. && cd .. && cd backend && npm init -y && npm i express && npm i mongoose && npm i cors && npm i axios && npm i dotenv && mkdir controllers && mkdir models && mkdir routes && echo. > config.ts && echo. > server.ts && echo. > .env && cd .. && cd client && npm start";
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/k {command}",
                UseShellExecute = true,
                CreateNoWindow = false,
            };
        
            Process.Start(startInfo);
        }
    }
}
