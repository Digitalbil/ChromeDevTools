﻿using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public interface IChromeSession
    {
        Task<ICommandResponse> SendAsync<T>(T parameter);

        Task<ICommandResponse> SendAsync<T>();

        void Subscribe<T>(EventHandler handler);
    }
}