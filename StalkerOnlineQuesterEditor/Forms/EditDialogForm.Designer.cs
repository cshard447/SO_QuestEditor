﻿namespace StalkerOnlineQuesterEditor
{
    partial class EditDialogForm
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tPlayerText = new System.Windows.Forms.TextBox();
            this.lAnswerText = new System.Windows.Forms.Label();
            this.NPCSaidIs = new System.Windows.Forms.Label();
            this.NPCSaid = new System.Windows.Forms.Label();
            this.lAttention = new System.Windows.Forms.Label();
            this.actionsBox = new System.Windows.Forms.GroupBox();
            this.ColorizeItemCheckBox = new System.Windows.Forms.CheckBox();
            this.ToClanBaseCheckBox = new System.Windows.Forms.CheckBox();
            this.barterCheckBox = new System.Windows.Forms.CheckBox();
            this.toComplexRepairCheckBox = new System.Windows.Forms.CheckBox();
            this.teleportComboBox = new System.Windows.Forms.ComboBox();
            this.teleportCheckBox = new System.Windows.Forms.CheckBox();
            this.toRepairCheckBox = new System.Windows.Forms.CheckBox();
            this.changeCheckBox = new System.Windows.Forms.CheckBox();
            this.CompleteQuestsTextBox = new System.Windows.Forms.MaskedTextBox();
            this.GetQuestsTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ToDialogComboBox = new System.Windows.Forms.ComboBox();
            this.ExitCheckBox = new System.Windows.Forms.CheckBox();
            this.toTradeCheckBox = new System.Windows.Forms.CheckBox();
            this.CompleteQuestsCheckBox = new System.Windows.Forms.CheckBox();
            this.GetQuestsCheckBox = new System.Windows.Forms.CheckBox();
            this.ToDialogCheckBox = new System.Windows.Forms.CheckBox();
            this.actionsCheckBox = new System.Windows.Forms.CheckBox();
            this.tNPCReactiontextBox = new System.Windows.Forms.TextBox();
            this.tSubDialogsTextBox = new System.Windows.Forms.MaskedTextBox();
            this.subDialogsLabel = new System.Windows.Forms.Label();
            this.PreconditionBox = new System.Windows.Forms.GroupBox();
            this.cbShowClanOptions = new System.Windows.Forms.CheckBox();
            this.gbClanOptions = new System.Windows.Forms.GroupBox();
            this.cbLonerOnly = new System.Windows.Forms.CheckBox();
            this.cbAnyClanOnly = new System.Windows.Forms.CheckBox();
            this.cbSameClanOnly = new System.Windows.Forms.CheckBox();
            this.mtbPlayerLevel = new System.Windows.Forms.MaskedTextBox();
            this.lPlayerLevel = new System.Windows.Forms.Label();
            this.bKarma = new System.Windows.Forms.Button();
            this.bReputation = new System.Windows.Forms.Button();
            this.QuestConditiongroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tShouldntHaveFailedQuests = new System.Windows.Forms.MaskedTextBox();
            this.tMustHaveFailedQuests = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tMustHaveQuestsOnTest = new System.Windows.Forms.MaskedTextBox();
            this.tShouldntHaveCompletedQuests = new System.Windows.Forms.MaskedTextBox();
            this.tMustHaveOpenQuests = new System.Windows.Forms.MaskedTextBox();
            this.tShouldntHaveQuestsOnTest = new System.Windows.Forms.MaskedTextBox();
            this.tShouldntHaveOpenQuests = new System.Windows.Forms.MaskedTextBox();
            this.tMustHaveCompletedQuests = new System.Windows.Forms.MaskedTextBox();
            this.bEditDialogOk = new System.Windows.Forms.Button();
            this.bEditDialogCancel = new System.Windows.Forms.Button();
            this.NPCReactionText = new System.Windows.Forms.Label();
            this.MustPanel = new System.Windows.Forms.Panel();
            this.textGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateClanCheckBox = new System.Windows.Forms.CheckBox();
            this.actionsBox.SuspendLayout();
            this.PreconditionBox.SuspendLayout();
            this.gbClanOptions.SuspendLayout();
            this.QuestConditiongroupBox.SuspendLayout();
            this.MustPanel.SuspendLayout();
            this.textGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tPlayerText
            // 
            this.tPlayerText.Location = new System.Drawing.Point(103, 46);
            this.tPlayerText.Name = "tPlayerText";
            this.tPlayerText.Size = new System.Drawing.Size(479, 20);
            this.tPlayerText.TabIndex = 0;
            this.tPlayerText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tPlayerText_KeyPress);
            // 
            // lAnswerText
            // 
            this.lAnswerText.AutoSize = true;
            this.lAnswerText.Location = new System.Drawing.Point(3, 46);
            this.lAnswerText.Name = "lAnswerText";
            this.lAnswerText.Size = new System.Drawing.Size(86, 13);
            this.lAnswerText.TabIndex = 1;
            this.lAnswerText.Text = "Вариант ответа";
            // 
            // NPCSaidIs
            // 
            this.NPCSaidIs.AutoSize = true;
            this.NPCSaidIs.Location = new System.Drawing.Point(107, 9);
            this.NPCSaidIs.Name = "NPCSaidIs";
            this.NPCSaidIs.Size = new System.Drawing.Size(13, 13);
            this.NPCSaidIs.TabIndex = 11;
            this.NPCSaidIs.Text = "  ";
            // 
            // NPCSaid
            // 
            this.NPCSaid.AutoSize = true;
            this.NPCSaid.Location = new System.Drawing.Point(3, 9);
            this.NPCSaid.Name = "NPCSaid";
            this.NPCSaid.Size = new System.Drawing.Size(98, 13);
            this.NPCSaid.TabIndex = 12;
            this.NPCSaid.Text = "Приветствие NPC";
            // 
            // lAttention
            // 
            this.lAttention.AutoSize = true;
            this.lAttention.ForeColor = System.Drawing.Color.DarkRed;
            this.lAttention.Location = new System.Drawing.Point(107, 78);
            this.lAttention.Name = "lAttention";
            this.lAttention.Size = new System.Drawing.Size(51, 13);
            this.lAttention.TabIndex = 13;
            this.lAttention.Text = "lAttention";
            // 
            // actionsBox
            // 
            this.actionsBox.Controls.Add(this.CreateClanCheckBox);
            this.actionsBox.Controls.Add(this.ColorizeItemCheckBox);
            this.actionsBox.Controls.Add(this.ToClanBaseCheckBox);
            this.actionsBox.Controls.Add(this.barterCheckBox);
            this.actionsBox.Controls.Add(this.toComplexRepairCheckBox);
            this.actionsBox.Controls.Add(this.teleportComboBox);
            this.actionsBox.Controls.Add(this.teleportCheckBox);
            this.actionsBox.Controls.Add(this.toRepairCheckBox);
            this.actionsBox.Controls.Add(this.changeCheckBox);
            this.actionsBox.Controls.Add(this.CompleteQuestsTextBox);
            this.actionsBox.Controls.Add(this.GetQuestsTextBox);
            this.actionsBox.Controls.Add(this.ToDialogComboBox);
            this.actionsBox.Controls.Add(this.ExitCheckBox);
            this.actionsBox.Controls.Add(this.toTradeCheckBox);
            this.actionsBox.Controls.Add(this.CompleteQuestsCheckBox);
            this.actionsBox.Controls.Add(this.GetQuestsCheckBox);
            this.actionsBox.Controls.Add(this.ToDialogCheckBox);
            this.actionsBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionsBox.Enabled = false;
            this.actionsBox.Location = new System.Drawing.Point(0, 500);
            this.actionsBox.Name = "actionsBox";
            this.actionsBox.Size = new System.Drawing.Size(588, 141);
            this.actionsBox.TabIndex = 8;
            this.actionsBox.TabStop = false;
            // 
            // ColorizeItemCheckBox
            // 
            this.ColorizeItemCheckBox.AutoSize = true;
            this.ColorizeItemCheckBox.Location = new System.Drawing.Point(131, 109);
            this.ColorizeItemCheckBox.Name = "ColorizeItemCheckBox";
            this.ColorizeItemCheckBox.Size = new System.Drawing.Size(76, 17);
            this.ColorizeItemCheckBox.TabIndex = 32;
            this.ColorizeItemCheckBox.Text = "Покраска";
            this.ColorizeItemCheckBox.UseVisualStyleBackColor = true;
            this.ColorizeItemCheckBox.CheckedChanged += new System.EventHandler(this.AnyActionCheckBox_CheckedChanged);
            // 
            // ToClanBaseCheckBox
            // 
            this.ToClanBaseCheckBox.AutoSize = true;
            this.ToClanBaseCheckBox.Location = new System.Drawing.Point(280, 89);
            this.ToClanBaseCheckBox.Name = "ToClanBaseCheckBox";
            this.ToClanBaseCheckBox.Size = new System.Drawing.Size(115, 17);
            this.ToClanBaseCheckBox.TabIndex = 31;
            this.ToClanBaseCheckBox.Text = "Телепорт на базу";
            this.ToClanBaseCheckBox.UseVisualStyleBackColor = true;
            this.ToClanBaseCheckBox.CheckedChanged += new System.EventHandler(this.AnyActionCheckBox_CheckedChanged);
            // 
            // barterCheckBox
            // 
            this.barterCheckBox.AutoSize = true;
            this.barterCheckBox.Location = new System.Drawing.Point(20, 88);
            this.barterCheckBox.Name = "barterCheckBox";
            this.barterCheckBox.Size = new System.Drawing.Size(62, 17);
            this.barterCheckBox.TabIndex = 21;
            this.barterCheckBox.Text = "Бартер";
            this.barterCheckBox.UseVisualStyleBackColor = true;
            this.barterCheckBox.CheckedChanged += new System.EventHandler(this.AnyActionCheckBox_CheckedChanged);
            // 
            // toComplexRepairCheckBox
            // 
            this.toComplexRepairCheckBox.AutoSize = true;
            this.toComplexRepairCheckBox.Location = new System.Drawing.Point(131, 87);
            this.toComplexRepairCheckBox.Name = "toComplexRepairCheckBox";
            this.toComplexRepairCheckBox.Size = new System.Drawing.Size(139, 17);
            this.toComplexRepairCheckBox.TabIndex = 23;
            this.toComplexRepairCheckBox.Text = "Комплексная починка";
            this.toComplexRepairCheckBox.UseVisualStyleBackColor = true;
            this.toComplexRepairCheckBox.CheckedChanged += new System.EventHandler(this.AnyActionCheckBox_CheckedChanged);
            // 
            // teleportComboBox
            // 
            this.teleportComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.teleportComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.teleportComboBox.DropDownWidth = 250;
            this.teleportComboBox.Enabled = false;
            this.teleportComboBox.FormattingEnabled = true;
            this.teleportComboBox.Location = new System.Drawing.Point(400, 66);
            this.teleportComboBox.Name = "teleportComboBox";
            this.teleportComboBox.Size = new System.Drawing.Size(147, 21);
            this.teleportComboBox.TabIndex = 30;
            // 
            // teleportCheckBox
            // 
            this.teleportCheckBox.AutoSize = true;
            this.teleportCheckBox.Location = new System.Drawing.Point(280, 67);
            this.teleportCheckBox.Name = "teleportCheckBox";
            this.teleportCheckBox.Size = new System.Drawing.Size(74, 17);
            this.teleportCheckBox.TabIndex = 29;
            this.teleportCheckBox.Text = "Телепорт";
            this.teleportCheckBox.UseVisualStyleBackColor = true;
            this.teleportCheckBox.CheckedChanged += new System.EventHandler(this.teleportCheckBox_CheckedChanged);
            // 
            // toRepairCheckBox
            // 
            this.toRepairCheckBox.AutoSize = true;
            this.toRepairCheckBox.Location = new System.Drawing.Point(131, 65);
            this.toRepairCheckBox.Name = "toRepairCheckBox";
            this.toRepairCheckBox.Size = new System.Drawing.Size(69, 17);
            this.toRepairCheckBox.TabIndex = 22;
            this.toRepairCheckBox.Text = "Починка";
            this.toRepairCheckBox.UseVisualStyleBackColor = true;
            this.toRepairCheckBox.CheckedChanged += new System.EventHandler(this.AnyActionCheckBox_CheckedChanged);
            // 
            // changeCheckBox
            // 
            this.changeCheckBox.AutoSize = true;
            this.changeCheckBox.Location = new System.Drawing.Point(20, 67);
            this.changeCheckBox.Name = "changeCheckBox";
            this.changeCheckBox.Size = new System.Drawing.Size(60, 17);
            this.changeCheckBox.TabIndex = 20;
            this.changeCheckBox.Text = "Обмен";
            this.changeCheckBox.UseVisualStyleBackColor = true;
            this.changeCheckBox.CheckedChanged += new System.EventHandler(this.AnyActionCheckBox_CheckedChanged);
            // 
            // CompleteQuestsTextBox
            // 
            this.CompleteQuestsTextBox.Enabled = false;
            this.CompleteQuestsTextBox.Location = new System.Drawing.Point(400, 44);
            this.CompleteQuestsTextBox.Name = "CompleteQuestsTextBox";
            this.CompleteQuestsTextBox.Size = new System.Drawing.Size(147, 20);
            this.CompleteQuestsTextBox.TabIndex = 28;
            // 
            // GetQuestsTextBox
            // 
            this.GetQuestsTextBox.Enabled = false;
            this.GetQuestsTextBox.Location = new System.Drawing.Point(400, 22);
            this.GetQuestsTextBox.Name = "GetQuestsTextBox";
            this.GetQuestsTextBox.Size = new System.Drawing.Size(147, 20);
            this.GetQuestsTextBox.TabIndex = 26;
            // 
            // ToDialogComboBox
            // 
            this.ToDialogComboBox.Enabled = false;
            this.ToDialogComboBox.FormattingEnabled = true;
            this.ToDialogComboBox.Location = new System.Drawing.Point(131, 25);
            this.ToDialogComboBox.Name = "ToDialogComboBox";
            this.ToDialogComboBox.Size = new System.Drawing.Size(100, 21);
            this.ToDialogComboBox.TabIndex = 18;
            // 
            // ExitCheckBox
            // 
            this.ExitCheckBox.AutoSize = true;
            this.ExitCheckBox.Location = new System.Drawing.Point(280, 111);
            this.ExitCheckBox.Name = "ExitCheckBox";
            this.ExitCheckBox.Size = new System.Drawing.Size(141, 17);
            this.ExitCheckBox.TabIndex = 24;
            this.ExitCheckBox.Text = "Закрыть окно диалога";
            this.ExitCheckBox.UseVisualStyleBackColor = true;
            this.ExitCheckBox.CheckedChanged += new System.EventHandler(this.AnyActionCheckBox_CheckedChanged);
            // 
            // toTradeCheckBox
            // 
            this.toTradeCheckBox.AutoSize = true;
            this.toTradeCheckBox.Location = new System.Drawing.Point(20, 46);
            this.toTradeCheckBox.Name = "toTradeCheckBox";
            this.toTradeCheckBox.Size = new System.Drawing.Size(79, 17);
            this.toTradeCheckBox.TabIndex = 19;
            this.toTradeCheckBox.Text = "Торговать";
            this.toTradeCheckBox.UseVisualStyleBackColor = true;
            this.toTradeCheckBox.CheckedChanged += new System.EventHandler(this.AnyActionCheckBox_CheckedChanged);
            // 
            // CompleteQuestsCheckBox
            // 
            this.CompleteQuestsCheckBox.AutoSize = true;
            this.CompleteQuestsCheckBox.Location = new System.Drawing.Point(280, 45);
            this.CompleteQuestsCheckBox.Name = "CompleteQuestsCheckBox";
            this.CompleteQuestsCheckBox.Size = new System.Drawing.Size(119, 17);
            this.CompleteQuestsCheckBox.TabIndex = 27;
            this.CompleteQuestsCheckBox.Text = "Закончить квесты";
            this.CompleteQuestsCheckBox.UseVisualStyleBackColor = true;
            this.CompleteQuestsCheckBox.CheckedChanged += new System.EventHandler(this.CompleteQuestsCheckBox_CheckedChanged);
            // 
            // GetQuestsCheckBox
            // 
            this.GetQuestsCheckBox.AutoSize = true;
            this.GetQuestsCheckBox.Location = new System.Drawing.Point(280, 23);
            this.GetQuestsCheckBox.Name = "GetQuestsCheckBox";
            this.GetQuestsCheckBox.Size = new System.Drawing.Size(96, 17);
            this.GetQuestsCheckBox.TabIndex = 25;
            this.GetQuestsCheckBox.Text = "Взять квесты";
            this.GetQuestsCheckBox.UseVisualStyleBackColor = true;
            this.GetQuestsCheckBox.CheckedChanged += new System.EventHandler(this.GetQuestsCheckBox_CheckedChanged);
            // 
            // ToDialogCheckBox
            // 
            this.ToDialogCheckBox.AutoSize = true;
            this.ToDialogCheckBox.Location = new System.Drawing.Point(20, 25);
            this.ToDialogCheckBox.Name = "ToDialogCheckBox";
            this.ToDialogCheckBox.Size = new System.Drawing.Size(114, 17);
            this.ToDialogCheckBox.TabIndex = 17;
            this.ToDialogCheckBox.Text = "Переход на диал.";
            this.ToDialogCheckBox.UseVisualStyleBackColor = true;
            this.ToDialogCheckBox.CheckedChanged += new System.EventHandler(this.ToDialogCheckBox1_CheckedChanged);
            // 
            // actionsCheckBox
            // 
            this.actionsCheckBox.AutoSize = true;
            this.actionsCheckBox.Location = new System.Drawing.Point(6, 498);
            this.actionsCheckBox.Name = "actionsCheckBox";
            this.actionsCheckBox.Size = new System.Drawing.Size(76, 17);
            this.actionsCheckBox.TabIndex = 16;
            this.actionsCheckBox.Text = "Действия";
            this.actionsCheckBox.UseVisualStyleBackColor = true;
            this.actionsCheckBox.CheckedChanged += new System.EventHandler(this.actionsCheckBox_CheckedChanged);
            // 
            // tNPCReactiontextBox
            // 
            this.tNPCReactiontextBox.Location = new System.Drawing.Point(103, 103);
            this.tNPCReactiontextBox.Multiline = true;
            this.tNPCReactiontextBox.Name = "tNPCReactiontextBox";
            this.tNPCReactiontextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tNPCReactiontextBox.Size = new System.Drawing.Size(479, 88);
            this.tNPCReactiontextBox.TabIndex = 1;
            // 
            // tSubDialogsTextBox
            // 
            this.tSubDialogsTextBox.Location = new System.Drawing.Point(103, 197);
            this.tSubDialogsTextBox.Name = "tSubDialogsTextBox";
            this.tSubDialogsTextBox.Size = new System.Drawing.Size(479, 20);
            this.tSubDialogsTextBox.TabIndex = 2;
            // 
            // subDialogsLabel
            // 
            this.subDialogsLabel.AutoSize = true;
            this.subDialogsLabel.Location = new System.Drawing.Point(3, 204);
            this.subDialogsLabel.Name = "subDialogsLabel";
            this.subDialogsLabel.Size = new System.Drawing.Size(68, 13);
            this.subDialogsLabel.TabIndex = 9;
            this.subDialogsLabel.Text = "Поддиалоги";
            // 
            // PreconditionBox
            // 
            this.PreconditionBox.Controls.Add(this.cbShowClanOptions);
            this.PreconditionBox.Controls.Add(this.gbClanOptions);
            this.PreconditionBox.Controls.Add(this.mtbPlayerLevel);
            this.PreconditionBox.Controls.Add(this.lPlayerLevel);
            this.PreconditionBox.Controls.Add(this.bKarma);
            this.PreconditionBox.Controls.Add(this.bReputation);
            this.PreconditionBox.Controls.Add(this.QuestConditiongroupBox);
            this.PreconditionBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PreconditionBox.Location = new System.Drawing.Point(0, 227);
            this.PreconditionBox.Name = "PreconditionBox";
            this.PreconditionBox.Size = new System.Drawing.Size(588, 273);
            this.PreconditionBox.TabIndex = 4;
            this.PreconditionBox.TabStop = false;
            this.PreconditionBox.Text = "Условия активности узла";
            // 
            // cbShowClanOptions
            // 
            this.cbShowClanOptions.AutoSize = true;
            this.cbShowClanOptions.Location = new System.Drawing.Point(395, 29);
            this.cbShowClanOptions.Name = "cbShowClanOptions";
            this.cbShowClanOptions.Size = new System.Drawing.Size(110, 17);
            this.cbShowClanOptions.TabIndex = 51;
            this.cbShowClanOptions.Text = "Клановые опции";
            this.cbShowClanOptions.UseVisualStyleBackColor = true;
            this.cbShowClanOptions.Click += new System.EventHandler(this.cbShowClanOptions_Click);
            // 
            // gbClanOptions
            // 
            this.gbClanOptions.BackColor = System.Drawing.SystemColors.Control;
            this.gbClanOptions.Controls.Add(this.cbLonerOnly);
            this.gbClanOptions.Controls.Add(this.cbAnyClanOnly);
            this.gbClanOptions.Controls.Add(this.cbSameClanOnly);
            this.gbClanOptions.Location = new System.Drawing.Point(376, 56);
            this.gbClanOptions.Name = "gbClanOptions";
            this.gbClanOptions.Size = new System.Drawing.Size(200, 100);
            this.gbClanOptions.TabIndex = 50;
            this.gbClanOptions.TabStop = false;
            this.gbClanOptions.Text = "Клановые опции";
            // 
            // cbLonerOnly
            // 
            this.cbLonerOnly.AutoSize = true;
            this.cbLonerOnly.Location = new System.Drawing.Point(19, 72);
            this.cbLonerOnly.Name = "cbLonerOnly";
            this.cbLonerOnly.Size = new System.Drawing.Size(134, 17);
            this.cbLonerOnly.TabIndex = 18;
            this.cbLonerOnly.Text = "Только для одиночек";
            this.cbLonerOnly.UseVisualStyleBackColor = true;
            // 
            // cbAnyClanOnly
            // 
            this.cbAnyClanOnly.AutoSize = true;
            this.cbAnyClanOnly.Location = new System.Drawing.Point(19, 48);
            this.cbAnyClanOnly.Name = "cbAnyClanOnly";
            this.cbAnyClanOnly.Size = new System.Drawing.Size(162, 17);
            this.cbAnyClanOnly.TabIndex = 17;
            this.cbAnyClanOnly.Text = "Только для имеющих клан";
            this.cbAnyClanOnly.UseVisualStyleBackColor = true;
            // 
            // cbSameClanOnly
            // 
            this.cbSameClanOnly.AutoSize = true;
            this.cbSameClanOnly.Location = new System.Drawing.Point(19, 24);
            this.cbSameClanOnly.Name = "cbSameClanOnly";
            this.cbSameClanOnly.Size = new System.Drawing.Size(147, 17);
            this.cbSameClanOnly.TabIndex = 16;
            this.cbSameClanOnly.Text = "Только для соклановца";
            this.cbSameClanOnly.UseVisualStyleBackColor = true;
            // 
            // mtbPlayerLevel
            // 
            this.mtbPlayerLevel.Location = new System.Drawing.Point(117, 215);
            this.mtbPlayerLevel.Mask = "000";
            this.mtbPlayerLevel.Name = "mtbPlayerLevel";
            this.mtbPlayerLevel.PromptChar = ' ';
            this.mtbPlayerLevel.Size = new System.Drawing.Size(100, 20);
            this.mtbPlayerLevel.TabIndex = 49;
            // 
            // lPlayerLevel
            // 
            this.lPlayerLevel.AutoSize = true;
            this.lPlayerLevel.Location = new System.Drawing.Point(13, 218);
            this.lPlayerLevel.Name = "lPlayerLevel";
            this.lPlayerLevel.Size = new System.Drawing.Size(92, 13);
            this.lPlayerLevel.TabIndex = 48;
            this.lPlayerLevel.Text = "Уровень игрока:";
            // 
            // bKarma
            // 
            this.bKarma.Location = new System.Drawing.Point(95, 175);
            this.bKarma.Name = "bKarma";
            this.bKarma.Size = new System.Drawing.Size(81, 23);
            this.bKarma.TabIndex = 47;
            this.bKarma.Text = "Карма";
            this.bKarma.UseVisualStyleBackColor = true;
            this.bKarma.Click += new System.EventHandler(this.bKarma_Click);
            // 
            // bReputation
            // 
            this.bReputation.Location = new System.Drawing.Point(8, 175);
            this.bReputation.Name = "bReputation";
            this.bReputation.Size = new System.Drawing.Size(81, 23);
            this.bReputation.TabIndex = 46;
            this.bReputation.Text = "Репутация";
            this.bReputation.UseVisualStyleBackColor = true;
            this.bReputation.Click += new System.EventHandler(this.bReputation_Click);
            // 
            // QuestConditiongroupBox
            // 
            this.QuestConditiongroupBox.Controls.Add(this.label6);
            this.QuestConditiongroupBox.Controls.Add(this.tShouldntHaveFailedQuests);
            this.QuestConditiongroupBox.Controls.Add(this.tMustHaveFailedQuests);
            this.QuestConditiongroupBox.Controls.Add(this.label5);
            this.QuestConditiongroupBox.Controls.Add(this.label4);
            this.QuestConditiongroupBox.Controls.Add(this.label3);
            this.QuestConditiongroupBox.Controls.Add(this.label2);
            this.QuestConditiongroupBox.Controls.Add(this.label1);
            this.QuestConditiongroupBox.Controls.Add(this.tMustHaveQuestsOnTest);
            this.QuestConditiongroupBox.Controls.Add(this.tShouldntHaveCompletedQuests);
            this.QuestConditiongroupBox.Controls.Add(this.tMustHaveOpenQuests);
            this.QuestConditiongroupBox.Controls.Add(this.tShouldntHaveQuestsOnTest);
            this.QuestConditiongroupBox.Controls.Add(this.tShouldntHaveOpenQuests);
            this.QuestConditiongroupBox.Controls.Add(this.tMustHaveCompletedQuests);
            this.QuestConditiongroupBox.Location = new System.Drawing.Point(8, 17);
            this.QuestConditiongroupBox.Name = "QuestConditiongroupBox";
            this.QuestConditiongroupBox.Size = new System.Drawing.Size(350, 152);
            this.QuestConditiongroupBox.TabIndex = 6;
            this.QuestConditiongroupBox.TabStop = false;
            this.QuestConditiongroupBox.Text = "Состояния квестов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Проваленные квесты";
            // 
            // tShouldntHaveFailedQuests
            // 
            this.tShouldntHaveFailedQuests.Location = new System.Drawing.Point(234, 119);
            this.tShouldntHaveFailedQuests.Name = "tShouldntHaveFailedQuests";
            this.tShouldntHaveFailedQuests.Size = new System.Drawing.Size(100, 20);
            this.tShouldntHaveFailedQuests.TabIndex = 10;
            // 
            // tMustHaveFailedQuests
            // 
            this.tMustHaveFailedQuests.Location = new System.Drawing.Point(128, 119);
            this.tMustHaveFailedQuests.Name = "tMustHaveFailedQuests";
            this.tMustHaveFailedQuests.Size = new System.Drawing.Size(100, 20);
            this.tMustHaveFailedQuests.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Не должно быть";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Должно быть";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Закрытые квесты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Квесты \"к проверке\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Открытые квесты";
            // 
            // tMustHaveQuestsOnTest
            // 
            this.tMustHaveQuestsOnTest.Location = new System.Drawing.Point(128, 66);
            this.tMustHaveQuestsOnTest.Name = "tMustHaveQuestsOnTest";
            this.tMustHaveQuestsOnTest.Size = new System.Drawing.Size(100, 20);
            this.tMustHaveQuestsOnTest.TabIndex = 4;
            // 
            // tShouldntHaveCompletedQuests
            // 
            this.tShouldntHaveCompletedQuests.Location = new System.Drawing.Point(234, 92);
            this.tShouldntHaveCompletedQuests.Name = "tShouldntHaveCompletedQuests";
            this.tShouldntHaveCompletedQuests.Size = new System.Drawing.Size(100, 20);
            this.tShouldntHaveCompletedQuests.TabIndex = 9;
            // 
            // tMustHaveOpenQuests
            // 
            this.tMustHaveOpenQuests.Location = new System.Drawing.Point(128, 40);
            this.tMustHaveOpenQuests.Name = "tMustHaveOpenQuests";
            this.tMustHaveOpenQuests.Size = new System.Drawing.Size(100, 20);
            this.tMustHaveOpenQuests.TabIndex = 3;
            // 
            // tShouldntHaveQuestsOnTest
            // 
            this.tShouldntHaveQuestsOnTest.Location = new System.Drawing.Point(234, 66);
            this.tShouldntHaveQuestsOnTest.Name = "tShouldntHaveQuestsOnTest";
            this.tShouldntHaveQuestsOnTest.Size = new System.Drawing.Size(100, 20);
            this.tShouldntHaveQuestsOnTest.TabIndex = 8;
            // 
            // tShouldntHaveOpenQuests
            // 
            this.tShouldntHaveOpenQuests.Location = new System.Drawing.Point(234, 40);
            this.tShouldntHaveOpenQuests.Name = "tShouldntHaveOpenQuests";
            this.tShouldntHaveOpenQuests.Size = new System.Drawing.Size(100, 20);
            this.tShouldntHaveOpenQuests.TabIndex = 7;
            // 
            // tMustHaveCompletedQuests
            // 
            this.tMustHaveCompletedQuests.Location = new System.Drawing.Point(128, 92);
            this.tMustHaveCompletedQuests.Name = "tMustHaveCompletedQuests";
            this.tMustHaveCompletedQuests.Size = new System.Drawing.Size(100, 20);
            this.tMustHaveCompletedQuests.TabIndex = 5;
            // 
            // bEditDialogOk
            // 
            this.bEditDialogOk.Location = new System.Drawing.Point(426, 3);
            this.bEditDialogOk.Name = "bEditDialogOk";
            this.bEditDialogOk.Size = new System.Drawing.Size(75, 23);
            this.bEditDialogOk.TabIndex = 11;
            this.bEditDialogOk.Text = "Ok";
            this.bEditDialogOk.UseVisualStyleBackColor = true;
            this.bEditDialogOk.Click += new System.EventHandler(this.bEditDialogOk_Click);
            // 
            // bEditDialogCancel
            // 
            this.bEditDialogCancel.Location = new System.Drawing.Point(507, 3);
            this.bEditDialogCancel.Name = "bEditDialogCancel";
            this.bEditDialogCancel.Size = new System.Drawing.Size(75, 23);
            this.bEditDialogCancel.TabIndex = 12;
            this.bEditDialogCancel.Text = "Отмена";
            this.bEditDialogCancel.UseVisualStyleBackColor = true;
            this.bEditDialogCancel.Click += new System.EventHandler(this.bEditDialogCancel_Click);
            // 
            // NPCReactionText
            // 
            this.NPCReactionText.AutoSize = true;
            this.NPCReactionText.Location = new System.Drawing.Point(3, 105);
            this.NPCReactionText.Name = "NPCReactionText";
            this.NPCReactionText.Size = new System.Drawing.Size(75, 13);
            this.NPCReactionText.TabIndex = 6;
            this.NPCReactionText.Text = "Реакция NPC";
            // 
            // MustPanel
            // 
            this.MustPanel.Controls.Add(this.bEditDialogCancel);
            this.MustPanel.Controls.Add(this.bEditDialogOk);
            this.MustPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MustPanel.Location = new System.Drawing.Point(0, 641);
            this.MustPanel.Name = "MustPanel";
            this.MustPanel.Size = new System.Drawing.Size(588, 33);
            this.MustPanel.TabIndex = 13;
            // 
            // textGroupBox
            // 
            this.textGroupBox.Controls.Add(this.tSubDialogsTextBox);
            this.textGroupBox.Controls.Add(this.subDialogsLabel);
            this.textGroupBox.Controls.Add(this.tNPCReactiontextBox);
            this.textGroupBox.Controls.Add(this.tPlayerText);
            this.textGroupBox.Controls.Add(this.lAnswerText);
            this.textGroupBox.Controls.Add(this.NPCSaidIs);
            this.textGroupBox.Controls.Add(this.NPCSaid);
            this.textGroupBox.Controls.Add(this.lAttention);
            this.textGroupBox.Controls.Add(this.NPCReactionText);
            this.textGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.textGroupBox.Location = new System.Drawing.Point(0, 0);
            this.textGroupBox.Name = "textGroupBox";
            this.textGroupBox.Size = new System.Drawing.Size(588, 227);
            this.textGroupBox.TabIndex = 15;
            this.textGroupBox.TabStop = false;
            // 
            // CreateClanCheckBox
            // 
            this.CreateClanCheckBox.AutoSize = true;
            this.CreateClanCheckBox.Location = new System.Drawing.Point(20, 109);
            this.CreateClanCheckBox.Name = "CreateClanCheckBox";
            this.CreateClanCheckBox.Size = new System.Drawing.Size(95, 17);
            this.CreateClanCheckBox.TabIndex = 33;
            this.CreateClanCheckBox.Text = "Создать клан";
            this.CreateClanCheckBox.UseVisualStyleBackColor = true;
            this.CreateClanCheckBox.CheckedChanged += new System.EventHandler(this.AnyActionCheckBox_CheckedChanged);
            // 
            // EditDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 679);
            this.Controls.Add(this.actionsCheckBox);
            this.Controls.Add(this.MustPanel);
            this.Controls.Add(this.actionsBox);
            this.Controls.Add(this.PreconditionBox);
            this.Controls.Add(this.textGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditDialogForm";
            this.Text = "Редактирование диалога";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditDialogForm_FormClosed);
            this.actionsBox.ResumeLayout(false);
            this.actionsBox.PerformLayout();
            this.PreconditionBox.ResumeLayout(false);
            this.PreconditionBox.PerformLayout();
            this.gbClanOptions.ResumeLayout(false);
            this.gbClanOptions.PerformLayout();
            this.QuestConditiongroupBox.ResumeLayout(false);
            this.QuestConditiongroupBox.PerformLayout();
            this.MustPanel.ResumeLayout(false);
            this.textGroupBox.ResumeLayout(false);
            this.textGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tPlayerText;
        private System.Windows.Forms.Label lAnswerText;
        private System.Windows.Forms.Label NPCSaidIs;
        private System.Windows.Forms.Label NPCSaid;
        private System.Windows.Forms.Label lAttention;
        private System.Windows.Forms.GroupBox actionsBox;
        private System.Windows.Forms.CheckBox toComplexRepairCheckBox;
        private System.Windows.Forms.ComboBox teleportComboBox;
        private System.Windows.Forms.CheckBox teleportCheckBox;
        private System.Windows.Forms.CheckBox toRepairCheckBox;
        private System.Windows.Forms.CheckBox changeCheckBox;
        private System.Windows.Forms.MaskedTextBox CompleteQuestsTextBox;
        private System.Windows.Forms.MaskedTextBox GetQuestsTextBox;
        private System.Windows.Forms.ComboBox ToDialogComboBox;
        private System.Windows.Forms.CheckBox ExitCheckBox;
        private System.Windows.Forms.CheckBox toTradeCheckBox;
        private System.Windows.Forms.CheckBox CompleteQuestsCheckBox;
        private System.Windows.Forms.CheckBox GetQuestsCheckBox;
        private System.Windows.Forms.CheckBox ToDialogCheckBox;
        private System.Windows.Forms.TextBox tNPCReactiontextBox;
        private System.Windows.Forms.MaskedTextBox tSubDialogsTextBox;
        private System.Windows.Forms.Label subDialogsLabel;
        private System.Windows.Forms.CheckBox actionsCheckBox;
        private System.Windows.Forms.GroupBox PreconditionBox;
        private System.Windows.Forms.GroupBox QuestConditiongroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tMustHaveQuestsOnTest;
        private System.Windows.Forms.MaskedTextBox tShouldntHaveCompletedQuests;
        private System.Windows.Forms.MaskedTextBox tMustHaveOpenQuests;
        private System.Windows.Forms.MaskedTextBox tShouldntHaveQuestsOnTest;
        private System.Windows.Forms.MaskedTextBox tShouldntHaveOpenQuests;
        private System.Windows.Forms.MaskedTextBox tMustHaveCompletedQuests;
        private System.Windows.Forms.Button bEditDialogOk;
        private System.Windows.Forms.Button bEditDialogCancel;
        private System.Windows.Forms.Label NPCReactionText;
        private System.Windows.Forms.Panel MustPanel;
        private System.Windows.Forms.GroupBox textGroupBox;
        private System.Windows.Forms.Button bReputation;
        private System.Windows.Forms.Button bKarma;
        private System.Windows.Forms.CheckBox barterCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tShouldntHaveFailedQuests;
        private System.Windows.Forms.MaskedTextBox tMustHaveFailedQuests;
        private System.Windows.Forms.CheckBox ToClanBaseCheckBox;
        private System.Windows.Forms.MaskedTextBox mtbPlayerLevel;
        private System.Windows.Forms.Label lPlayerLevel;
        private System.Windows.Forms.CheckBox cbShowClanOptions;
        private System.Windows.Forms.GroupBox gbClanOptions;
        private System.Windows.Forms.CheckBox cbLonerOnly;
        private System.Windows.Forms.CheckBox cbAnyClanOnly;
        private System.Windows.Forms.CheckBox cbSameClanOnly;
        private System.Windows.Forms.CheckBox ColorizeItemCheckBox;
        private System.Windows.Forms.CheckBox CreateClanCheckBox;
    }
}