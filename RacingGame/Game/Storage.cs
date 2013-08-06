using Microsoft.Xna.Framework.Storage;
using System;

namespace RacingGame
{
    public class Storage
    {
        public static StorageContainer OpenContainer(StorageDevice storageDevice, string saveGameName)
        {
            IAsyncResult result = storageDevice.BeginOpenContainer(saveGameName, null, null);

            // Wait for the WaitHandle to become signaled.
            result.AsyncWaitHandle.WaitOne();

            StorageContainer container = storageDevice.EndOpenContainer(result);

            // Close the wait handle.
            result.AsyncWaitHandle.Close();

            return container;
        }
    }
}
