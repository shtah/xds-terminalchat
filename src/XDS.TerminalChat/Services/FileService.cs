﻿using System;
using System.Threading.Tasks;
using XDS.Messaging.SDK.ApplicationBehavior.Services.Interfaces;

namespace XDS.Messaging.TerminalChat.Services
{
	public class FileService : IFileService
	{

		readonly byte[] DummyBytes = Guid.NewGuid().ToByteArray();

		public FileService()
		{
		}

		public string GetInstallLocation()
		{
			return AppDomain.CurrentDomain.BaseDirectory;
		}

		public string GetLocalFolderPath()
		{
			return FStoreInitializer.CreateFStoreConfig().StoreLocation.FullName;
		}

		public Task<object> LoadAssetImageAsync(string name)
		{
			throw new NotImplementedException();
		}

		public Task<object> LoadAssetImageBrushAsync(string name)
		{
			throw new NotImplementedException();
		}

		public async Task<byte[]> LoadAssetImageBytesAsync(string name)
		{
			return this.DummyBytes;
		}

		public Task<object> LoadLocalImageAsync(string imagePath)
		{
			throw new NotImplementedException();
		}

		public Task<object> LoadLocalImageBrushAsync(string imagePath)
		{
			throw new NotImplementedException();
		}

		public void SetLocalFolderPathForTests(string localFolderPathOverride)
		{
			throw new NotImplementedException();
		}
	}
}