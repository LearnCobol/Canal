﻿using Canal.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Canal
{
    using Level88ToEnum;
    using Utils;

    public partial class MainWindow : Form
    {
        private readonly TabUtil _tabUtil;

        public CodeBox CurrentCodeBox
        {
            get
            {
                if (_tabUtil.CurrentFileControl != null && _tabUtil.CurrentFileControl.CodeBox != null)
                    return _tabUtil.CurrentFileControl.CodeBox;
                return null;
            }
        }

        public MainWindow(string[] files = null)
        {
            InitializeComponent();

            ErrorHandling.Start();

            _tabUtil = new TabUtil(FileTabs, this);
            try
            {
                var toOpen = new List<string>();
                if (files != null) toOpen.AddRange(files);
                if (Settings.Default.LastOpened != null) toOpen.AddRange(Settings.Default.LastOpened.Cast<string>());

                foreach (string filepath in new HashSet<string>(toOpen))
                    OpenFile(filepath);
            }
            catch (Exception exception)
            {
                ErrorHandling.Exception(exception);
                MessageBox.Show(Resources.ErrorMessage_MainWindow_OpenPrevious + exception.Message, Resources.Error, MessageBoxButtons.OK);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Settings.Default.LastOpened = new StringCollection();
            Settings.Default.LastOpened.AddRange(_tabUtil.GetOpenFiles().Select(file => file.FileReference.FullPath).ToArray());
            Settings.Default.Save();
            ErrorHandling.End();
            base.OnClosing(e);
        }

        public void OpenFile(string filename)
        {
            if (_tabUtil.TryShowTab(filename))
                return;

            Cursor = Cursors.WaitCursor;

            try
            {
                IncludeFileType(Path.GetExtension(filename));
                var file = FileUtil.Get(filename);
                _tabUtil.AddTab(file);

            }
            catch (Exception exception)
            {
                ErrorHandling.Exception(exception);
                MessageBox.Show(Resources.ErrorMessage_MainWindow_ErrorLoadingFile + exception.Message, Resources.Error, MessageBoxButtons.OK);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void IncludeFileType(string fileEnding)
        {
            switch (fileEnding.ToLowerInvariant())
            {
                case ".cob":
                    settings_sourceCodeFiles_cobol.Checked = true;
                    Settings.Default.FileTypeCob = true;
                    break;
                case ".cbl":
                    settings_sourceCodeFiles_cobol.Checked = true;
                    Settings.Default.FileTypeCob = true;
                    break;
                case ".txt":
                    settings_sourceCodeFiles_text.Checked = true;
                    Settings.Default.FileTypeTxt = true;
                    break;
                case ".src":
                    settings_sourceCodeFiles_source.Checked = true;
                    Settings.Default.FileTypeSrc = true;
                    break;
                default:
                    ErrorHandling.Info("Wrong File Extension " + fileEnding);
                    break;
            }
            Settings.Default.Save();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = @"COBOL Files|*.cob;*.cbl;*.txt;.src";
            openFileDialog.FileName = "";

            var dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                OpenFile(openFileDialog.FileName);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tabUtil.CloseTab();
        }

        private void level88ToEnumConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var converterWindow = new Level88ToEnum();
            converterWindow.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_tabUtil.CloseAllTabs())
                Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tabUtil.AddTab(new CobolFile("", "New File"));
        }

        private void settings_sourceCodeFiles_Click(object sender, EventArgs e)
        {
            Settings.Default.FileTypeCob = settings_sourceCodeFiles_cobol.Checked;
            Settings.Default.FileTypeTxt = settings_sourceCodeFiles_text.Checked;
            Settings.Default.FileTypeSrc = settings_sourceCodeFiles_source.Checked;
            Settings.Default.Save();
        }
    }
}
