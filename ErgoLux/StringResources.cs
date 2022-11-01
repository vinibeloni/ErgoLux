namespace ErgoLux;

public static class StringResources
{
    /// <summary>
    /// Represents a resource manager that provides convinient access to culture-specific resources at run time
    /// </summary>
    public static System.Resources.ResourceManager StringRM { get; set; } = new("ErgoLux.localization.strings", typeof(FrmMain).Assembly);

    /// <summary>
    /// Specific culture from which the string resources will be retrieved
    /// </summary>
    public static System.Globalization.CultureInfo Culture { get; set; } = System.Globalization.CultureInfo.CurrentCulture;

    public static string GetString(string StringName, System.Globalization.CultureInfo Culture) => StringRM.GetString(StringName, Culture) ?? string.Empty;

    public static string BtnAccept => StringRM.GetString("strBtnAccept", Culture) ?? "&Accept";
    public static string BtnCancel => StringRM.GetString("strBtnCancel", Culture) ?? "&Cancel";
    public static string BtnData => StringRM.GetString("strBtnData", Culture) ?? "Select data";
    public static string BtnExport => StringRM.GetString("strBtnExport", Culture) ?? "&Export";
    public static string BtnReset => StringRM.GetString("strBtnReset", Culture) ?? "&Reset";
    public static string BtnSettings => StringRM.GetString("strBtnSettings", Culture) ?? "&Settings";
    public static string ChkCrossHair => StringRM.GetString("strChkCrossHair", Culture) ?? "Show plots' crosshair";
    public static string ChkCumulative => StringRM.GetString("strChkCumulative", Culture) ?? "Cumulative fractal dimension";
    public static string ChkDlgPath => StringRM.GetString("strChkDlgPath", Culture) ?? "Remember open/save dialog previous path";
    public static string ChkEntropy => StringRM.GetString("strChkEntropy", Culture) ?? "Entropy (approximate && sample)";
    public static string ChkPlotAverage => StringRM.GetString("strChkPlotAverage", Culture) ?? "Plot average";
    public static string ChkPlotDistribution => StringRM.GetString("strChkPlotDistribution", Culture) ?? "Plot distribution";
    public static string ChkPlotRatios => StringRM.GetString("strChkPlotRatios", Culture) ?? "Plot ratios";
    public static string ChkPlotRaw => StringRM.GetString("strChkPlotRaw", Culture) ?? "Plot raw data";
    public static string ChkPower => StringRM.GetString("strChkPower", Culture) ?? "Power (dB)";
    public static string ErrorDeserialize => StringRM.GetString("strErrorDeserialize", Culture) ?? "Error loading settings file." + Environment.NewLine + Environment.NewLine + "{0}" + Environment.NewLine + Environment.NewLine + "Default values will be used instead.";
    public static string ErrorDeserializeTitle => StringRM.GetString("strErrorDeserializeTitle", Culture) ?? "Error";
    public static string FileHeader01 => StringRM.GetString("strFileHeader01", Culture) ?? "ErgoLux data";
    public static string FileHeader02 => StringRM.GetString("strFileHeader02", Culture) ?? "Start time";
    public static string FileHeader03 => StringRM.GetString("strFileHeader03", Culture) ?? "End time";
    public static string FileHeader04 => StringRM.GetString("strFileHeader04", Culture) ?? "Total measuring time";
    public static string FileHeader05 => StringRM.GetString("strFileHeader05", Culture) ?? "Number of sensors";
    public static string FileHeader06 => StringRM.GetString("strFileHeader06", Culture) ?? "Number of data points";
    public static string FileHeader07 => StringRM.GetString("strFileHeader07", Culture) ?? "Sampling frequency";
    public static string FileHeader08 => StringRM.GetString("strFileHeader08", Culture) ?? "Sensor #";
    public static string FileHeader09 => StringRM.GetString("strFileHeader09", Culture) ?? "Maximum";
    public static string FileHeader10 => StringRM.GetString("strFileHeader10", Culture) ?? "Average";
    public static string FileHeader11 => StringRM.GetString("strFileHeader11", Culture) ?? "Minimum";
    public static string FileHeader12 => StringRM.GetString("strFileHeader12", Culture) ?? "Min/Average";
    public static string FileHeader13 => StringRM.GetString("strFileHeader13", Culture) ?? "Min/Max";
    public static string FileHeader14 => StringRM.GetString("strFileHeader14", Culture) ?? "Average/Max";
    public static string FileHeader15 => StringRM.GetString("strFileHeader15", Culture) ?? "Average";
    public static string FileHeader16 => StringRM.GetString("strFileHeader16", Culture) ?? "Illuminance";
    public static string FileHeader17 => StringRM.GetString("strFileHeader17", Culture) ?? "Missing an empty line.";
    public static string FileHeader18 => StringRM.GetString("strFileHeader18", Culture) ?? "Missing column headers (series names).";
    public static string FileHeader19 => StringRM.GetString("strFileHeader19", Culture) ?? "days";
    public static string FileHeader20 => StringRM.GetString("strFileHeader20", Culture) ?? "hours";
    public static string FileHeader21 => StringRM.GetString("strFileHeader21", Culture) ?? "minutes";
    public static string FileHeader22 => StringRM.GetString("strFileHeader22", Culture) ?? "seconds";
    public static string FileHeader23 => StringRM.GetString("strFileHeader23", Culture) ?? "and";
    public static string FileHeader24 => StringRM.GetString("strFileHeader24", Culture) ?? "milliseconds";
    public static string FileHeaderSection => StringRM.GetString("strFileHeaderSection", Culture) ?? "Section '{0}' is mis-formatted.";
    public static string FormTitle => StringRM.GetString("strFormTitle", Culture) ?? "ErgoLux";
    public static string FrmLanguage => StringRM.GetString("strFrmLanguage", Culture) ?? "Select culture";
    public static string FrmSettings => StringRM.GetString("strFrmSettings", Culture) ?? "Settings";
    public static string FrmTitle => StringRM.GetString("strFrmTitle", Culture) ?? "ErgoLux";
    public static string FrmTitleUnion => StringRM.GetString("strFrmTitleUnion", Culture) ?? " - ";
    public static string GridDescription => StringRM.GetString("strGridDescription", Culture) ?? "Description";
    public static string GridDevice => StringRM.GetString("strGridDevice", Culture) ?? "Device location";
    public static string GridFlags => StringRM.GetString("strGridFlags", Culture) ?? "Flags";
    public static string GridID => StringRM.GetString("strGridID", Culture) ?? "ID";
    public static string GridLocation => StringRM.GetString("strGridLocation", Culture) ?? "Location ID";
    public static string GridSerial => StringRM.GetString("strGridSerial", Culture) ?? "Serial number";
    public static string GridType => StringRM.GetString("strGridType", Culture) ?? "Type";
    public static string GrpAxis => StringRM.GetString("strGrpAxis", Culture) ?? "Abscissa axis";
    public static string GrpCulture => StringRM.GetString("strGrpCulture", Culture) ?? "UI and data format";
    public static string GrpPlot => StringRM.GetString("strGrpPlot", Culture) ?? "Plot distribution";
    public static string LblArrayPoints => StringRM.GetString("strLblArrayPoints", Culture) ?? "Array minimum points";
    public static string LblBaudRate => StringRM.GetString("strLblBaudRate", Culture) ?? "Baud rate";
    public static string LblData => StringRM.GetString("strLblData", Culture) ?? "Data-file path";
    public static string LblDataBits => StringRM.GetString("strLblDataBits", Culture) ?? "Data bits";
    public static string LblDataFormat => StringRM.GetString("strLblDataFormat", Culture) ?? "Numeric data-formatting string";
    public static string LblDeviceList => StringRM.GetString("strLblDeviceList", Culture) ?? "FTDI device list";
    public static string LblEnd => StringRM.GetString("strLblEnd", Culture) ?? "Array index end";
    public static string LblFlow => StringRM.GetString("strLblFlow", Culture) ?? "Flow control";
    public static string LblFrequency => StringRM.GetString("strLblFrequency", Culture) ?? "Frequency (Hz)";
    public static string LblOff => StringRM.GetString("strLblOff", Culture) ?? "Off";
    public static string LblOn => StringRM.GetString("strLblOn", Culture) ?? "On";
    public static string LblParity => StringRM.GetString("strLblParity", Culture) ?? "Parity";
    public static string LblPlotWindow => StringRM.GetString("strLblPlotWindow", Culture) ?? "Plot window (seconds)";
    public static string LblSensors => StringRM.GetString("strLblSensors", Culture) ?? "Number of sensors";
    public static string LblSeries => StringRM.GetString("strLblSeries", Culture) ?? "Select series";
    public static string LblStart => StringRM.GetString("strLblStart", Culture) ?? "Array index start";
    public static string LblStopBits => StringRM.GetString("strLblStopBits", Culture) ?? "Stop bits";
    public static string LblWindow => StringRM.GetString("strLblWindow", Culture) ?? "Window";
    public static string MenuMainFile => StringRM.GetString("strMenuMainFile", Culture) ?? "&File";
    public static string MenuMainFileExit => StringRM.GetString("strMenuMainFileExit", Culture) ?? "&Exit...";
    public static string MenuMainFileOpen => StringRM.GetString("strMenuMainFileOpen", Culture) ?? "&Open...";
    public static string MenuMainFileSave => StringRM.GetString("strMenuMainFileSave", Culture) ?? "&Save...";
    public static string MenuMainHelpAbout => StringRM.GetString("strMenuMainHelpAbout", Culture) ?? "&About...";
    public static string MenuMainHelpText => StringRM.GetString("strMenuMainHelpText", Culture) ?? "&Help";
    public static string MenuMainTools => StringRM.GetString("strMenuMainTools", Culture) ?? "&Tools";
    public static string MenuMainToolsConnect => StringRM.GetString("strMenuMainToolsConnect", Culture) ?? "&Connect";
    public static string MenuMainToolsDisconnect => StringRM.GetString("strMenuMainToolsDisconnect", Culture) ?? "&Disconnect";
    public static string MenuMainToolsSettings => StringRM.GetString("strMenuMainToolsSettings", Culture) ?? "&Settings...";
    public static string MenuMainView => StringRM.GetString("strMenuMainView", Culture) ?? "&View";
    public static string MenuMainViewAverage => StringRM.GetString("strMenuMainViewAverage", Culture) ?? "Averages";
    public static string MenuMainViewDistribution => StringRM.GetString("strMenuMainViewDistribution", Culture) ?? "Radial distribution";
    public static string MenuMainViewMenu => StringRM.GetString("strMenuMainViewMenu", Culture) ?? "Show menu";
    public static string MenuMainViewRatio => StringRM.GetString("strMenuMainViewRatio", Culture) ?? "Ratios";
    public static string MenuMainViewRaw => StringRM.GetString("strMenuMainViewRaw", Culture) ?? "Raw data";
    public static string MenuMainViewToolbar => StringRM.GetString("strMenuMainViewToolbar", Culture) ?? "Show toolbar";
    public static string MsbBoxErrorBits => StringRM.GetString("strMsbBoxErrorBits", Culture) ?? "Failed to set data characteristics" + Environment.NewLine + "(data bits, stop bits, and parity)." + Environment.NewLine + "Error:" + Environment.NewLine + "{0}";
    public static string MsgBoxErrorBaudRate => StringRM.GetString("strMsgBoxErrorBaudRate", Culture) ?? "Failed to set Baud rate." + Environment.NewLine + "Error:" + Environment.NewLine + "{0}";
    public static string MsgBoxErrorBaudRateTitle => StringRM.GetString("strMsgBoxErrorBaudRateTitle", Culture) ?? "Baud rate error";
    public static string MsgBoxErrorBitsTitle => StringRM.GetString("strMsgBoxErrorBitsTitle", Culture) ?? "Bits error";
    public static string MsgBoxErrorDeviceClosed => StringRM.GetString("strMsgBoxErrorDeviceClosed", Culture) ?? "The device is closed. Please, go to" + Environment.NewLine + "'Settings' to open the device.";
    public static string MsgBoxErrorDeviceClosedTitle => StringRM.GetString("strMsgBoxErrorDeviceClosedTitle", Culture) ?? "Device error";
    public static string MsgBoxErrorDrivers => StringRM.GetString("strMsgBoxErrorDrivers", Culture) ?? "Failed to load FTD2XX.DLL. Are the FTDI drivers installed?";
    public static string MsgBoxErrorDriversTitle => StringRM.GetString("strMsgBoxErrorDriversTitle", Culture) ?? "Error loading drivers";
    public static string MsgBoxErrorFlowControl => StringRM.GetString("strMsgBoxErrorFlowControl", Culture) ?? "Failed to set flow control." + Environment.NewLine + "Error:" + Environment.NewLine + "{0}";
    public static string MsgBoxErrorFlowControlTitle => StringRM.GetString("strMsgBoxErrorFlowControlTitle", Culture) ?? "Flow control error";
    public static string MsgBoxErrorLoading => StringRM.GetString("strMsgBoxErrorLoading", Culture) ?? "Attempting to load FTD2XX.DLL from:";
    public static string MsgBoxErrorLoadingTitle => StringRM.GetString("strMsgBoxErrorLoadingTitle", Culture) ?? "Error loading DLL";
    public static string MsgBoxErrorOpenData => StringRM.GetString("strMsgBoxErrorOpenData", Culture) ?? "An unexpected error happened while opening file data." + Environment.NewLine + "Please try again later or contact the software engineer." + Environment.NewLine + "{0}";
    public static string MsgBoxErrorOpenDataTitle => StringRM.GetString("strMsgBoxErrorOpenDataTitle", Culture) ?? "Error opening data";
    public static string MsgBoxErrorOpenDevice => StringRM.GetString("strMsgBoxErrorOpenDevice", Culture) ?? "Could not open the device";
    public static string MsgBoxErrorOpenDeviceTitle => StringRM.GetString("strMsgBoxErrorOpenDeviceTitle", Culture) ?? "Error";
    public static string MsgBoxErrorOpening => StringRM.GetString("strMsgBoxErrorOpening", Culture) ?? "Failed to open device." + Environment.NewLine + "Error:" + Environment.NewLine + "{0}";
    public static string MsgBoxErrorOpeningTitle => StringRM.GetString("strMsgBoxErrorOpeningTitle", Culture) ?? "Error opening device";
    public static string MsgBoxErrorSaveData => StringRM.GetString("strMsgBoxErrorSaveData", Culture) ?? "An unexpected error happened while saving data to disk." + Environment.NewLine + "Please try again later or contact the software engineer." + Environment.NewLine + "{0}";
    public static string MsgBoxErrorSaveDataTitle => StringRM.GetString("strMsgBoxErrorSaveDataTitle", Culture) ?? "Error saving data";
    public static string MsgBoxErrorSettings => StringRM.GetString("strMsgBoxErrorSettings", Culture) ?? "Error loading settings file." + Environment.NewLine + Environment.NewLine + "{0}" + Environment.NewLine + Environment.NewLine + "Default values will be used instead.";
    public static string MsgBoxErrorSettingsTitle => StringRM.GetString("strMsgBoxErrorSettingsTitle", Culture) ?? "Error";
    public static string MsgBoxErrorTimeouts => StringRM.GetString("strMsgBoxErrorTimeouts", Culture) ?? "Failed to set timeouts." + Environment.NewLine + "Error:" + Environment.NewLine + "{0}";
    public static string MsgBoxErrorTimeoutsTitle => StringRM.GetString("strMsgBoxErrorTimeoutsTitle", Culture) ?? "Timeouts error";
    public static string MsgBoxExit => StringRM.GetString("strMsgBoxExit", Culture) ?? "Are you sure you want to exit" + Environment.NewLine + "the application?";
    public static string MsgBoxExitTitle => StringRM.GetString("strMsgBoxExitTitle", Culture) ?? "Exit?";
    public static string MsgBoxNoData => StringRM.GetString("strMsgBoxNoData", Culture) ?? "There is no data available to be saved.";
    public static string MsgBoxNoDataTitle => StringRM.GetString("strMsgBoxNoDataTitle", Culture) ?? "No data";
    public static string MsgBoxReset => StringRM.GetString("strDlgReset", Culture) ?? "Do you want to reset all fields" + Environment.NewLine + "to their default values?";
    public static string MsgBoxResetTitle => StringRM.GetString("strDlgResetTitle", Culture) ?? "Reset settings?";
    public static string MsgBoxSaveData => StringRM.GetString("strMsgBoxSaveData", Culture) ?? "Data has been successfully saved to disk.";
    public static string MsgBoxSaveDataTitle => StringRM.GetString("strMsgBoxSaveDataTitle", Culture) ?? "Data saving";
    public static string MsgBoxTaskCancel => StringRM.GetString("strMsgBoxTaskCancel", Culture) ?? "Computation of the Hausdorff-Besicovitch fractal" + Environment.NewLine + "dimension has been stopped.";
    //public static string MsgBoxTaskCancel => StringRM.GetString("strMsgBoxTaskCancel", Culture) ?? $"Computation of the Hausdorff-Besicovitch fractal{Environment.NewLine}dimension has been stopped.";
    public static string MsgBoxTaskCancelTitle => StringRM.GetString("strMsgBoxTaskCancelTitle", Culture) ?? "Stop";
    public static string OpenDlgFilter => StringRM.GetString("strOpenDlgFilter", Culture) ?? "ErgoLux file (*.elux)|*.elux|Text file (*.txt)|*.txt|Binary file (*.bin)|*.bin|All files (*.*)|*.*";
    public static string OpenDlgTitle => StringRM.GetString("strOpenDlgTitle", Culture) ?? "Open illuminance data";
    public static string PlotAverageTitle => StringRM.GetString("strPlotAverageTitle", Culture) ?? "Max, average, min";
    public static string PlotAverageXLabel => StringRM.GetString("strPlotAverageXLabel", Culture) ?? "Time (seconds)";
    public static string PlotAverageYLabel => StringRM.GetString("strPlotAverageYLabel", Culture) ?? "Lux";
    public static string PlotDistributionTitle => StringRM.GetString("strPlotDistributionTitle", Culture) ?? "Illuminance distribution";
    public static string PlotRatiosTitle => StringRM.GetString("strPlotRatiosTitle", Culture) ?? "Illuminance ratios";
    public static string PlotRatiosXLabel => StringRM.GetString("strPlotRatiosXLabel", Culture) ?? "Time (seconds)";
    public static string PlotRatiosYLabel => StringRM.GetString("strPlotRatiosYLabel", Culture) ?? "Ratio";
    public static string PlotRawTitle => StringRM.GetString("strPlotRawTitle", Culture) ?? "Illuminance";
    public static string PlotRawXLabel => StringRM.GetString("strPlotRawXLabel", Culture) ?? "Time (seconds)";
    public static string PlotRawYLabel => StringRM.GetString("strPlotRawYLabel", Culture) ?? "Lux";
    public static string RadCurrentCulture => StringRM.GetString("strRadCurrentCulture", Culture) ?? "Current culture formatting";
    public static string RadInvariantCulture => StringRM.GetString("strRadInvariantCulture", Culture) ?? "Invariant culture formatting";
    public static string RadRadar => StringRM.GetString("strRadRadar", Culture) ?? "Radar";
    public static string RadRadialGauge => StringRM.GetString("strRadRadialGauge", Culture) ?? "Radial gauge";
    public static string RadUserCulture => StringRM.GetString("strRadUserCulture", Culture) ?? "Select culture";
    public static string ReadDataError => StringRM.GetString("strReadDataError", Culture) ?? "Unable to read data from file." + Environment.NewLine + "{0}";
    public static string ReadDataErrorCulture => StringRM.GetString("strReadDataErrorCulture", Culture) ?? "The culture identifier string name is not valid." + Environment.NewLine + "{0}";
    public static string ReadDataErrorCultureTitle => StringRM.GetString("strReadDataErrorCultureTitle", Culture) ?? "Culture name error";
    public static string ReadDataErrorNumber => StringRM.GetString("strReadDataErrorNumber", Culture) ?? "Invalid numeric value: {0}";
    public static string ReadDataErrorNumberTitle => StringRM.GetString("strReadDataErrorNumberTitle", Culture) ?? "Error parsing data";
    public static string ReadDataErrorTitle => StringRM.GetString("strReadDataErrorTitle", Culture) ?? "Error opening data";
    public static string SaveDlgFilter => StringRM.GetString("strSaveDlgFilter", Culture) ?? "ErgoLux file(*.elux)|*.elux|Text file(*.txt)|*.txt|Binary file(*.bin)|*.bin|All files(*.*)|*.*";
    public static string SaveDlgTitle => StringRM.GetString("strSaveDlgTitle", Culture) ?? "Save illuminance data";
    public static string StatusExchange => StringRM.GetString("strStatusExchange", Culture) ?? "Receiving data";
    public static string StatusID => StringRM.GetString("strStatusID", Culture) ?? "Device ID";
    public static string StatusLocation => StringRM.GetString("strStatusLocation", Culture) ?? "Location ID";
    public static string StatusOpen => StringRM.GetString("strStatusOpen", Culture) ?? "Disconnected";
    public static string StatusTipCrossHair => StringRM.GetString("strStatusTipCrossHair", Culture) ?? "Show plot's crosshair mode";
    public static string StatusTipDistribution => StringRM.GetString("strStatusTipDistribution", Culture) ?? "Plot distribution";
    public static string StatusTipExchange => StringRM.GetString("strStatusTipExchange", Culture) ?? "Exchange status";
    public static string StatusTipID => StringRM.GetString("strStatusTipID", Culture) ?? "Device ID";
    public static string StatusTipLocation => StringRM.GetString("strStatusTipLocation", Culture) ?? "T-10A location ID";
    public static string StatusTipMax => StringRM.GetString("strStatusTipMax", Culture) ?? "Plot max, average and min";
    public static string StatusTipOpen => StringRM.GetString("strStatusTipOpen", Culture) ?? "Connexion status";
    public static string StatusTipRatio => StringRM.GetString("strStatusTipRatio", Culture) ?? "Plot ratios";
    public static string StatusTipRaw => StringRM.GetString("strStatusTipRaw", Culture) ?? "Plot raw data";
    public static string StatusTipType => StringRM.GetString("strStatusTipType", Culture) ?? "Device type";
    public static string StatusType => StringRM.GetString("strStatusType", Culture) ?? "Device type";
    public static string TabDevice => StringRM.GetString("strTabDevice", Culture) ?? "T-10A sensor";
    public static string TabGUI => StringRM.GetString("strTabGUI", Culture) ?? "User interface";
    public static string TabPlots => StringRM.GetString("strTabPlots", Culture) ?? "Plotting";
    public static string ToolStripAbout => StringRM.GetString("strToolStripAbout", Culture) ?? "About";
    public static string ToolStripConnect => StringRM.GetString("strToolStripConnect", Culture) ?? "Connect";
    public static string ToolStripDisconnect => StringRM.GetString("strToolStripDisconnect", Culture) ?? "Disconnect";
    public static string ToolStripExit => StringRM.GetString("strToolStripExit", Culture) ?? "Exit";
    public static string ToolStripOpen => StringRM.GetString("strToolStripOpen", Culture) ?? "Open";
    public static string ToolStripSave => StringRM.GetString("strToolStripSave", Culture) ?? "Save";
    public static string ToolStripSettings => StringRM.GetString("strToolStripSettings", Culture) ?? "Settings";
    public static string ToolTipAbout => StringRM.GetString("strToolTipAbout", Culture) ?? "About this software";
    public static string ToolTipConnect => StringRM.GetString("strToolTipConnect", Culture) ?? "Start receiving data from T-10A device";
    public static string ToolTipDisconnect => StringRM.GetString("strToolTipDisconnect", Culture) ?? "Stop and disconnect T-10A device";
    public static string ToolTipExit => StringRM.GetString("strToolTipExit", Culture) ?? "Exit the application";
    public static string ToolTipOpen => StringRM.GetString("strToolTipOpen", Culture) ?? "Open data file from disk";
    public static string ToolTipSave => StringRM.GetString("strToolTipSave", Culture) ?? "Save data";
    public static string ToolTipSettings => StringRM.GetString("strToolTipSettings", Culture) ?? "Settings for plots, data, and UI";
    public static string ToolTipUILanguage => StringRM.GetString("strToolTipUILanguage", Culture) ?? "User interface language";

}