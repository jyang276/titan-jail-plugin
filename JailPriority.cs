using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Advanced_Combat_Tracker;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Text.RegularExpressions;
using System.Linq;
[assembly: AssemblyTitle("JailPriority Plugin")]
[assembly: AssemblyVersion("1.0.0.3")]

namespace ACT_Plugin
{
    public class JailPriority : UserControl, IActPluginV1
    {
        #region Designer Created Code (Avoid editing)
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.player1TextBox = new System.Windows.Forms.TextBox();
            this.player2TextBox = new System.Windows.Forms.TextBox();
            this.player3TextBox = new System.Windows.Forms.TextBox();
            this.player4TextBox = new System.Windows.Forms.TextBox();
            this.player5TextBox = new System.Windows.Forms.TextBox();
            this.player6TextBox = new System.Windows.Forms.TextBox();
            this.player7TextBox = new System.Windows.Forms.TextBox();
            this.player8TextBox = new System.Windows.Forms.TextBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tts1TextBox = new System.Windows.Forms.TextBox();
            this.tts2TextBox = new System.Windows.Forms.TextBox();
            this.tts3TextBox = new System.Windows.Forms.TextBox();
            this.tts4TextBox = new System.Windows.Forms.TextBox();
            this.tts5TextBox = new System.Windows.Forms.TextBox();
            this.tts6TextBox = new System.Windows.Forms.TextBox();
            this.tts7TextBox = new System.Windows.Forms.TextBox();
            this.tts8TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.logsTextBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.player1TextBox);
            this.panel1.Controls.Add(this.player2TextBox);
            this.panel1.Controls.Add(this.player3TextBox);
            this.panel1.Controls.Add(this.player4TextBox);
            this.panel1.Controls.Add(this.player5TextBox);
            this.panel1.Controls.Add(this.player6TextBox);
            this.panel1.Controls.Add(this.player7TextBox);
            this.panel1.Controls.Add(this.player8TextBox);
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 211);
            this.panel1.TabIndex = 8;
            // 
            // player1TextBox
            // 
            this.player1TextBox.Location = new System.Drawing.Point(12, 17);
            this.player1TextBox.Name = "player1TextBox";
            this.player1TextBox.Size = new System.Drawing.Size(176, 20);
            this.player1TextBox.TabIndex = 8;
            this.player1TextBox.TextChanged += new System.EventHandler(this.updatePlayers);
            // 
            // player2TextBox
            // 
            this.player2TextBox.Location = new System.Drawing.Point(12, 40);
            this.player2TextBox.Name = "player2TextBox";
            this.player2TextBox.Size = new System.Drawing.Size(176, 20);
            this.player2TextBox.TabIndex = 9;
            this.player2TextBox.TextChanged += new System.EventHandler(this.updatePlayers);
            // 
            // player3TextBox
            // 
            this.player3TextBox.Location = new System.Drawing.Point(12, 63);
            this.player3TextBox.Name = "player3TextBox";
            this.player3TextBox.Size = new System.Drawing.Size(176, 20);
            this.player3TextBox.TabIndex = 10;
            this.player3TextBox.TextChanged += new System.EventHandler(this.updatePlayers);
            // 
            // player4TextBox
            // 
            this.player4TextBox.Location = new System.Drawing.Point(12, 86);
            this.player4TextBox.Name = "player4TextBox";
            this.player4TextBox.Size = new System.Drawing.Size(176, 20);
            this.player4TextBox.TabIndex = 11;
            this.player4TextBox.TextChanged += new System.EventHandler(this.updatePlayers);
            // 
            // player5TextBox
            // 
            this.player5TextBox.Location = new System.Drawing.Point(12, 109);
            this.player5TextBox.Name = "player5TextBox";
            this.player5TextBox.Size = new System.Drawing.Size(176, 20);
            this.player5TextBox.TabIndex = 12;
            this.player5TextBox.TextChanged += new System.EventHandler(this.updatePlayers);
            // 
            // player6TextBox
            // 
            this.player6TextBox.Location = new System.Drawing.Point(12, 132);
            this.player6TextBox.Name = "player6TextBox";
            this.player6TextBox.Size = new System.Drawing.Size(176, 20);
            this.player6TextBox.TabIndex = 13;
            this.player6TextBox.TextChanged += new System.EventHandler(this.updatePlayers);
            // 
            // player7TextBox
            // 
            this.player7TextBox.Location = new System.Drawing.Point(12, 154);
            this.player7TextBox.Name = "player7TextBox";
            this.player7TextBox.Size = new System.Drawing.Size(176, 20);
            this.player7TextBox.TabIndex = 14;
            this.player7TextBox.TextChanged += new System.EventHandler(this.updatePlayers);
            // 
            // player8TextBox
            // 
            this.player8TextBox.Location = new System.Drawing.Point(12, 177);
            this.player8TextBox.Name = "player8TextBox";
            this.player8TextBox.Size = new System.Drawing.Size(176, 20);
            this.player8TextBox.TabIndex = 15;
            this.player8TextBox.TextChanged += new System.EventHandler(this.updatePlayers);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(130, 244);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 9;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportPriorityList);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(3, 244);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 10;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importPriorityList);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(437, 33);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(201, 80);
            this.instructionLabel.TabIndex = 11;
            this.instructionLabel.Text = "1. Write priority list.\r\n2. Select your name.\r\n3. Set up your TSS triggers.\r\n\r\nyo" +
    "u can export/import priority list.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tts1TextBox);
            this.panel2.Controls.Add(this.tts2TextBox);
            this.panel2.Controls.Add(this.tts3TextBox);
            this.panel2.Controls.Add(this.tts4TextBox);
            this.panel2.Controls.Add(this.tts5TextBox);
            this.panel2.Controls.Add(this.tts6TextBox);
            this.panel2.Controls.Add(this.tts7TextBox);
            this.panel2.Controls.Add(this.tts8TextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(211, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 211);
            this.panel2.TabIndex = 13;
            // 
            // tts1TextBox
            // 
            this.tts1TextBox.Location = new System.Drawing.Point(30, 8);
            this.tts1TextBox.Name = "tts1TextBox";
            this.tts1TextBox.Size = new System.Drawing.Size(163, 20);
            this.tts1TextBox.TabIndex = 3;
            this.tts1TextBox.Text = "First";
            this.tts1TextBox.TextChanged += new System.EventHandler(this.updateTSS);
            // 
            // tts2TextBox
            // 
            this.tts2TextBox.Location = new System.Drawing.Point(30, 34);
            this.tts2TextBox.Name = "tts2TextBox";
            this.tts2TextBox.Size = new System.Drawing.Size(163, 20);
            this.tts2TextBox.TabIndex = 4;
            this.tts2TextBox.Text = "Second";
            this.tts2TextBox.TextChanged += new System.EventHandler(this.updateTSS);
            // 
            // tts3TextBox
            // 
            this.tts3TextBox.Location = new System.Drawing.Point(30, 60);
            this.tts3TextBox.Name = "tts3TextBox";
            this.tts3TextBox.Size = new System.Drawing.Size(163, 20);
            this.tts3TextBox.TabIndex = 5;
            this.tts3TextBox.Text = "Third";
            this.tts3TextBox.TextChanged += new System.EventHandler(this.updateTSS);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "3rd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "2nd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "1st";
            // 
            // logsTextBox
            // 
            this.logsTextBox.Location = new System.Drawing.Point(15, 273);
            this.logsTextBox.MaxLength = 1000000;
            this.logsTextBox.Multiline = true;
            this.logsTextBox.Name = "logsTextBox";
            this.logsTextBox.ReadOnly = true;
            this.logsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logsTextBox.Size = new System.Drawing.Size(427, 148);
            this.logsTextBox.TabIndex = 14;
            this.logsTextBox.Text = "Started..";
            this.logsTextBox.WordWrap = false;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 424);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(132, 13);
            this.infoLabel.TabIndex = 15;
            this.infoLabel.Text = "Discord: @Tarutella#3846";
            // 
            // textBox4
            // 
            this.tts4TextBox.Location = new System.Drawing.Point(30, 86);
            this.tts4TextBox.Name = "tts4TextBox";
            this.tts4TextBox.Size = new System.Drawing.Size(163, 20);
            this.tts4TextBox.TabIndex = 6;
            this.tts4TextBox.Text = "Fourth";
            this.tts4TextBox.TextChanged += new System.EventHandler(this.updateTSS);
            // 
            // textBox5
            // 
            this.tts5TextBox.Location = new System.Drawing.Point(31, 112);
            this.tts5TextBox.Name = "tts5TextBox";
            this.tts5TextBox.Size = new System.Drawing.Size(163, 20);
            this.tts5TextBox.TabIndex = 7;
            this.tts5TextBox.Text = "First";
            this.tts5TextBox.TextChanged += new System.EventHandler(this.updateTSS);
            // 
            // textBox6
            // 
            this.tts6TextBox.Location = new System.Drawing.Point(31, 138);
            this.tts6TextBox.Name = "tts6TextBox";
            this.tts6TextBox.Size = new System.Drawing.Size(163, 20);
            this.tts6TextBox.TabIndex = 8;
            this.tts6TextBox.Text = "Sixth";
            this.tts6TextBox.TextChanged += new System.EventHandler(this.updateTSS);
            // 
            // textBox7
            // 
            this.tts7TextBox.Location = new System.Drawing.Point(30, 162);
            this.tts7TextBox.Name = "tts7TextBox";
            this.tts7TextBox.Size = new System.Drawing.Size(163, 20);
            this.tts7TextBox.TabIndex = 9;
            this.tts7TextBox.Text = "Seventh";
            this.tts7TextBox.TextChanged += new System.EventHandler(this.updateTSS);
            // 
            // textBox8
            // 
            this.tts8TextBox.Location = new System.Drawing.Point(31, 188);
            this.tts8TextBox.Name = "tts8TextBox    ";
            this.tts8TextBox.Size = new System.Drawing.Size(163, 20);
            this.tts8TextBox.TabIndex = 10;
            this.tts8TextBox.Text = "Eighth";
            this.tts8TextBox.TextChanged += new System.EventHandler(this.updateTSS);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "4th";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "5th";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "6th";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "7th";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "8th";
            // 
            // JailPriority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.logsTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.panel1);
            this.Name = "JailPriority";
            this.Size = new System.Drawing.Size(969, 493);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        #endregion
        public JailPriority()
        {
            InitializeComponent();
        }
        Label lblStatus;    // The status label that appears in ACT's Plugin tab
        string settingsFile = Path.Combine(ActGlobals.oFormActMain.AppDataFolder.FullName, "Config\\TitanJail.config.xml");
        private Panel panel1;
        private TextBox player8TextBox;
        private TextBox player7TextBox;
        private TextBox player6TextBox;
        private TextBox player5TextBox;
        private TextBox player4TextBox;
        private TextBox player3TextBox;
        private TextBox player2TextBox;
        private TextBox player1TextBox;
        private Button exportButton;
        private Button importButton;
        private Label instructionLabel;
        private Label label2;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox tts1TextBox;
        private TextBox tts2TextBox;
        private TextBox tts3TextBox;
        private TextBox tts4TextBox;
        private TextBox tts5TextBox;
        private TextBox tts6TextBox;
        private TextBox tts7TextBox;
        private TextBox tts8TextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox logsTextBox;
        private Label infoLabel;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label1;
        SettingsSerializer xmlSettings;

        #region IActPluginV1 Members
        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
            lblStatus = pluginStatusText;   // Hand the status label's reference to our local var
            pluginScreenSpace.Controls.Add(this);   // Add this UserControl to the tab ACT provides
            this.Dock = DockStyle.Fill; // Expand the UserControl to fill the tab's client space
            xmlSettings = new SettingsSerializer(this); // Create a new settings serializer and pass it this instance
            LoadSettings();
            ActGlobals.oFormActMain.OnLogLineRead += OFormActMain_OnLogLineRead;
            lblStatus.Text = "Plugin Started";
        }
        List<String> orderPlayers = new List<string>();// list of players matched in logLine
        List<String> order = new List<String>(); // List of TTS Callouts
        List<String> players = new List<String>(); // All players in priority list
        String regex = ":(.*)?:2B6(B|C):.*?:.*?:"; // regex for jails
        int countMatches = 0;// number of matchups to the regex
        int yourIndex = 0;// player's index in the priority list
        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        private void OFormActMain_OnLogLineRead(bool isImport, LogLineEventArgs logInfo)
        {
            var match = Regex.Match(logInfo.logLine, regex, RegexOptions.IgnoreCase);
            if (!match.Success)
                return;
            if (stopwatch.ElapsedMilliseconds > 1000)//if elapsed time since 1st matchup > 1 second. reset stopwatch
            {
                logsTextBox.Text += "\r\n\r\n" + "=======[RESET]=======";
                stopwatch.Reset();
                countMatches = 0;
                orderPlayers.Clear();
            }
            logsTextBox.Text += "\r\n" + logInfo.logLine;
            stopwatch.Start();
            for (int i = 0; i < players.Count; i++)
            {
                if (logInfo.logLine.Contains(players[i]))
                    orderPlayers.Add(players[i]);
            }
            countMatches++;
            int y = 0;
            if (countMatches != 3)
                return;
            if (countMatches != orderPlayers.Count)
            {
                logsTextBox.Text += "\r\n" + "-[Incorrect name/s in priority list!]-";
                return;
            }

            for (int i = 0; i < players.Count; i++)
            {
                if (orderPlayers.Contains(players[i]))
                {
                    var gaoledPlayer = order[i];
                    ActGlobals.oFormActMain.TTS(gaoledPlayer);

                    if (players[i] == players[yourIndex])
                    {
                        logsTextBox.Text += "\r\n" + "---[" + (i + 1) + "]---[" + players[i] + "]------>-----" + order[y] + "---<--[YOU]";
                    }
                    else
                    {
                        logsTextBox.Text += "\r\n" + "---[" + (i + 1) + "]---[" + players[i] + "]------>-----" + order[y] + "-------------";
                    }
                    y++;
                }
            }
        }
        
    public void DeInitPlugin()
        {
            // Unsubscribe from any events you listen to when exiting!
            ActGlobals.oFormActMain.OnLogLineRead -= OFormActMain_OnLogLineRead;
            SaveSettings();
            lblStatus.Text = "Plugin Exited";
        }
        #endregion


        void LoadSettings()
        {

            if (File.Exists(settingsFile))
            {
                FileStream fs = new FileStream(settingsFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                XmlTextReader xReader = new XmlTextReader(fs);
                TextBox[] Players = panel1.Controls.OfType<TextBox>().ToArray();
                TextBox[] Order = panel2.Controls.OfType<TextBox>().ToArray();
                try
                {
                    int i = 0;
                    int j = 0;
                    while (xReader.Read())
                    {
                        if (xReader.NodeType == XmlNodeType.Element)
                        {
                            if (xReader.Name == "Player")
                            {
                                String line = xReader.ReadElementContentAsString();
                                players.Add(line);
                                Players[i].Text = line;
                                i++;
                            }
                            if (xReader.Name == "Order")
                            {
                                String line = xReader.ReadElementContentAsString();
                                order.Add(line);
                                Order[j].Text = line;
                                j++;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Error loading settings: " + ex.Message;
                }
                xReader.Close();
            }
            else
            {
                updateTSS();
            }
        }
        void SaveSettings()
        {
            FileStream fs = new FileStream(settingsFile, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            XmlTextWriter xWriter = new XmlTextWriter(fs, Encoding.UTF8);
            TextBox[] Players = panel1.Controls.OfType<TextBox>().ToArray();
            TextBox[] Order = panel2.Controls.OfType<TextBox>().ToArray();
            xWriter.Formatting = Formatting.Indented;
            xWriter.Indentation = 1;
            xWriter.IndentChar = '\t';
            xWriter.WriteStartDocument(true);
            xWriter.WriteStartElement("Config");    // <Config>
            xWriter.WriteStartElement("You");
            xWriter.WriteValue(yourIndex);
            xWriter.WriteEndElement();
            for (int i = 0; i < Players.Length; i++)
            {
                xWriter.WriteStartElement("Player");
                xWriter.WriteValue(Players[i].Text);
                xWriter.WriteEndElement();
            }
            for (int i = 0; i < Order.Length; i++)
            {
                xWriter.WriteStartElement("Order");
                xWriter.WriteValue(Order[i].Text);
                xWriter.WriteEndElement();
            }
            xWriter.WriteEndElement();  // </Config>
            xWriter.WriteEndDocument(); // Tie up loose ends (shouldn't be any)
            xWriter.Flush();    // Flush the file buffer to disk
            xWriter.Close();
        }

        private void exportPriorityList(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "Priority.xml";
            // set filters - this can be done in properties as well
            savefile.Filter = "XML file (*.xml)|*.xml|All files (*.*)|*.*";
            savefile.RestoreDirectory = true;
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(savefile.FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
                    {
                        XmlTextWriter xWriter = new XmlTextWriter(fs, Encoding.UTF8);
                        TextBox[] Players = panel1.Controls.OfType<TextBox>().ToArray();
                        xWriter.Formatting = Formatting.Indented;
                        xWriter.Indentation = 1;
                        xWriter.IndentChar = '\t';
                        xWriter.WriteStartDocument(true);
                        xWriter.WriteStartElement("Priority");
                        for (int i = 0; i < Players.Length; i++)
                        {
                            xWriter.WriteStartElement("Player");
                            xWriter.WriteValue(Players[i].Text);
                            xWriter.WriteEndElement();
                        }
                        xWriter.WriteEndElement();
                        xWriter.WriteEndDocument();
                        xWriter.Flush();
                        xWriter.Close();
                    }
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Error Exporting File: " + ex.Message;
                }
            }
        }
        private void importPriorityList(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "XML file (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    try
                    {
                        FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                        TextBox[] Players = panel1.Controls.OfType<TextBox>().ToArray();
                        XmlTextReader xReader = new XmlTextReader(fs);
                        int i = 0;
                        while (xReader.Read())
                        {
                            if (xReader.NodeType == XmlNodeType.Element)
                            {
                                if (xReader.Name == "Player")
                                {
                                    Players[i].Text = xReader.ReadElementContentAsString();
                                    i++;
                                }
                            }
                        }
                        xReader.Close();
                    }
                    catch (Exception ex)
                    {
                        lblStatus.Text = "Error Importing File: " + ex.Message;
                    }

                }
            }
        }

        private void updatePlayers(object sender, EventArgs e)
        {
            players.Clear();
            TextBox[] Players = panel1.Controls.OfType<TextBox>().ToArray();
            for (int i = 0; i < Players.Length; i++)
            {
                players.Add(Players[i].Text);
            }
        }

        private void updateTSS(object sender, EventArgs e)
        {
            updateTSS();
        }
        private void updateTSS()
        {
            order.Clear();
            TextBox[] Order = panel2.Controls.OfType<TextBox>().ToArray();
            for (int i = 0; i < Order.Length; i++)
            {
                order.Add(Order[i].Text);
            }
        }
    }
}
