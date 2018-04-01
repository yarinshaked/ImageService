﻿using ImageService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageService.Commands
{
    public class NewFileCommand : ICommand
    {
        private IImageServiceModel m_model;

        public NewFileCommand(IImageServiceModel model)
        {
            m_model = model;
        }

        public string Execute(string[] args, out bool result)
        {
            string path = args[0];
            try
            {
                return m_model.AddFile(path, DateTime.Parse(args[1]), out result);
            } catch (Exception e)
            {
                result = false;
                return e.ToString();
            }
        }
    }
}
