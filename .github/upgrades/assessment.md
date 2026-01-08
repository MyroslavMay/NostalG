# Projects and dependencies analysis

This document provides a comprehensive overview of the projects and their dependencies in the context of upgrading to .NETCoreApp,Version=v10.0.

## Table of Contents

- [Executive Summary](#executive-Summary)
  - [Highlevel Metrics](#highlevel-metrics)
  - [Projects Compatibility](#projects-compatibility)
  - [Package Compatibility](#package-compatibility)
  - [API Compatibility](#api-compatibility)
- [Aggregate NuGet packages details](#aggregate-nuget-packages-details)
- [Top API Migration Challenges](#top-api-migration-challenges)
  - [Technologies and Features](#technologies-and-features)
  - [Most Frequent API Issues](#most-frequent-api-issues)
- [Projects Relationship Graph](#projects-relationship-graph)
- [Project Details](#project-details)

  - [NostalG.csproj](#nostalgcsproj)


## Executive Summary

### Highlevel Metrics

| Metric | Count | Status |
| :--- | :---: | :--- |
| Total Projects | 1 | All require upgrade |
| Total NuGet Packages | 0 | All compatible |
| Total Code Files | 10 |  |
| Total Code Files with Incidents | 9 |  |
| Total Lines of Code | 500 |  |
| Total Number of Issues | 198 |  |
| Estimated LOC to modify | 196+ | at least 39,2% of codebase |

### Projects Compatibility

| Project | Target Framework | Difficulty | Package Issues | API Issues | Est. LOC Impact | Description |
| :--- | :---: | :---: | :---: | :---: | :---: | :--- |
| [NostalG.csproj](#nostalgcsproj) | net48 | 🟡 Medium | 0 | 196 | 196+ | ClassicWinForms, Sdk Style = False |

### Package Compatibility

| Status | Count | Percentage |
| :--- | :---: | :---: |
| ✅ Compatible | 0 | 0,0% |
| ⚠️ Incompatible | 0 | 0,0% |
| 🔄 Upgrade Recommended | 0 | 0,0% |
| ***Total NuGet Packages*** | ***0*** | ***100%*** |

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 176 | High - Require code changes |
| 🟡 Source Incompatible | 20 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 246 |  |
| ***Total APIs Analyzed*** | ***442*** |  |

## Aggregate NuGet packages details

| Package | Current Version | Suggested Version | Projects | Description |
| :--- | :---: | :---: | :--- | :--- |

## Top API Migration Challenges

### Technologies and Features

| Technology | Issues | Percentage | Migration Path |
| :--- | :---: | :---: | :--- |
| Windows Forms | 176 | 89,8% | Windows Forms APIs for building Windows desktop applications with traditional Forms-based UI that are available in .NET on Windows. Enable Windows Desktop support: Option 1 (Recommended): Target net9.0-windows; Option 2: Add <UseWindowsDesktop>true</UseWindowsDesktop>; Option 3 (Legacy): Use Microsoft.NET.Sdk.WindowsDesktop SDK. |
| GDI+ / System.Drawing | 18 | 9,2% | System.Drawing APIs for 2D graphics, imaging, and printing that are available via NuGet package System.Drawing.Common. Note: Not recommended for server scenarios due to Windows dependencies; consider cross-platform alternatives like SkiaSharp or ImageSharp for new code. |
| Windows Forms Legacy Controls | 8 | 4,1% | Legacy Windows Forms controls that have been removed from .NET Core/5+ including StatusBar, DataGrid, ContextMenu, MainMenu, MenuItem, and ToolBar. These controls were replaced by more modern alternatives. Use ToolStrip, MenuStrip, ContextMenuStrip, and DataGridView instead. |
| Legacy Configuration System | 2 | 1,0% | Legacy XML-based configuration system (app.config/web.config) that has been replaced by a more flexible configuration model in .NET Core. The old system was rigid and XML-based. Migrate to Microsoft.Extensions.Configuration with JSON/environment variables; use System.Configuration.ConfigurationManager NuGet package as interim bridge if needed. |

### Most Frequent API Issues

| API | Count | Percentage | Category |
| :--- | :---: | :---: | :--- |
| T:System.Windows.Forms.Label | 18 | 9,2% | Binary Incompatible |
| T:System.Windows.Forms.Button | 16 | 8,2% | Binary Incompatible |
| T:System.Windows.Forms.AutoScaleMode | 9 | 4,6% | Binary Incompatible |
| P:System.Windows.Forms.Control.Name | 6 | 3,1% | Binary Incompatible |
| T:System.Windows.Forms.DockStyle | 6 | 3,1% | Binary Incompatible |
| T:System.Windows.Forms.FormBorderStyle | 6 | 3,1% | Binary Incompatible |
| P:System.Windows.Forms.Label.Text | 4 | 2,0% | Binary Incompatible |
| T:System.Windows.Forms.Form | 4 | 2,0% | Binary Incompatible |
| P:System.Windows.Forms.Control.Size | 4 | 2,0% | Binary Incompatible |
| T:System.Drawing.GraphicsUnit | 4 | 2,0% | Source Incompatible |
| T:System.Drawing.FontStyle | 4 | 2,0% | Source Incompatible |
| T:System.Drawing.Font | 4 | 2,0% | Source Incompatible |
| M:System.Windows.Forms.Form.#ctor | 4 | 2,0% | Binary Incompatible |
| M:System.Windows.Forms.Control.ResumeLayout(System.Boolean) | 3 | 1,5% | Binary Incompatible |
| T:System.Windows.Forms.Control.ControlCollection | 3 | 1,5% | Binary Incompatible |
| P:System.Windows.Forms.Control.Controls | 3 | 1,5% | Binary Incompatible |
| M:System.Windows.Forms.Control.ControlCollection.Add(System.Windows.Forms.Control) | 3 | 1,5% | Binary Incompatible |
| F:System.Windows.Forms.AutoScaleMode.Font | 3 | 1,5% | Binary Incompatible |
| P:System.Windows.Forms.ContainerControl.AutoScaleMode | 3 | 1,5% | Binary Incompatible |
| P:System.Windows.Forms.ContainerControl.AutoScaleDimensions | 3 | 1,5% | Binary Incompatible |
| P:System.Windows.Forms.Control.TabIndex | 3 | 1,5% | Binary Incompatible |
| P:System.Windows.Forms.Control.Location | 3 | 1,5% | Binary Incompatible |
| T:System.Windows.Forms.FlatStyle | 3 | 1,5% | Binary Incompatible |
| M:System.Windows.Forms.Control.SuspendLayout | 3 | 1,5% | Binary Incompatible |
| T:System.Windows.Forms.Application | 3 | 1,5% | Binary Incompatible |
| T:System.Windows.Forms.FormWindowState | 3 | 1,5% | Binary Incompatible |
| M:System.Windows.Forms.UserControl.#ctor | 2 | 1,0% | Binary Incompatible |
| P:System.Windows.Forms.Control.BackColor | 2 | 1,0% | Binary Incompatible |
| P:System.Windows.Forms.Control.ForeColor | 2 | 1,0% | Binary Incompatible |
| F:System.Drawing.GraphicsUnit.Point | 2 | 1,0% | Source Incompatible |
| M:System.Drawing.Font.#ctor(System.String,System.Single,System.Drawing.FontStyle,System.Drawing.GraphicsUnit,System.Byte) | 2 | 1,0% | Source Incompatible |
| P:System.Windows.Forms.Control.Font | 2 | 1,0% | Binary Incompatible |
| P:System.Windows.Forms.Control.Dock | 2 | 1,0% | Binary Incompatible |
| M:System.Windows.Forms.Form.Close | 2 | 1,0% | Binary Incompatible |
| P:System.Windows.Forms.Form.Text | 2 | 1,0% | Binary Incompatible |
| F:System.Windows.Forms.FormBorderStyle.None | 2 | 1,0% | Binary Incompatible |
| P:System.Windows.Forms.Form.FormBorderStyle | 2 | 1,0% | Binary Incompatible |
| P:System.Windows.Forms.Form.ClientSize | 2 | 1,0% | Binary Incompatible |
| M:System.Windows.Forms.Form.Dispose(System.Boolean) | 2 | 1,0% | Binary Incompatible |
| T:System.Windows.Forms.ContextMenu | 2 | 1,0% | Binary Incompatible |
| T:System.Windows.Forms.Menu.MenuItemCollection | 2 | 1,0% | Binary Incompatible |
| P:System.Windows.Forms.Menu.MenuItems | 2 | 1,0% | Binary Incompatible |
| T:System.Windows.Forms.MenuItem | 2 | 1,0% | Binary Incompatible |
| M:System.Windows.Forms.Menu.MenuItemCollection.Add(System.String) | 2 | 1,0% | Binary Incompatible |
| M:System.Windows.Forms.Control.PerformLayout | 1 | 0,5% | Binary Incompatible |
| E:System.Windows.Forms.Control.Click | 1 | 0,5% | Binary Incompatible |
| P:System.Windows.Forms.ButtonBase.UseVisualStyleBackColor | 1 | 0,5% | Binary Incompatible |
| P:System.Windows.Forms.ButtonBase.Text | 1 | 0,5% | Binary Incompatible |
| F:System.Drawing.FontStyle.Bold | 1 | 0,5% | Source Incompatible |
| F:System.Windows.Forms.FlatStyle.Flat | 1 | 0,5% | Binary Incompatible |

## Projects Relationship Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart LR
    P1["<b>⚙️&nbsp;NostalG.csproj</b><br/><small>net48</small>"]
    click P1 "#nostalgcsproj"

```

## Project Details

<a id="nostalgcsproj"></a>
### NostalG.csproj

#### Project Info

- **Current Target Framework:** net48
- **Proposed Target Framework:** net10.0-windows
- **SDK-style**: False
- **Project Kind:** ClassicWinForms
- **Dependencies**: 0
- **Dependants**: 0
- **Number of Files**: 14
- **Number of Files with Incidents**: 9
- **Lines of Code**: 500
- **Estimated LOC to modify**: 196+ (at least 39,2% of the project)

#### Dependency Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart TB
    subgraph current["NostalG.csproj"]
        MAIN["<b>⚙️&nbsp;NostalG.csproj</b><br/><small>net48</small>"]
        click MAIN "#nostalgcsproj"
    end

```

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 176 | High - Require code changes |
| 🟡 Source Incompatible | 20 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 246 |  |
| ***Total APIs Analyzed*** | ***442*** |  |

#### Project Technologies and Features

| Technology | Issues | Percentage | Migration Path |
| :--- | :---: | :---: | :--- |
| GDI+ / System.Drawing | 18 | 9,2% | System.Drawing APIs for 2D graphics, imaging, and printing that are available via NuGet package System.Drawing.Common. Note: Not recommended for server scenarios due to Windows dependencies; consider cross-platform alternatives like SkiaSharp or ImageSharp for new code. |
| Legacy Configuration System | 2 | 1,0% | Legacy XML-based configuration system (app.config/web.config) that has been replaced by a more flexible configuration model in .NET Core. The old system was rigid and XML-based. Migrate to Microsoft.Extensions.Configuration with JSON/environment variables; use System.Configuration.ConfigurationManager NuGet package as interim bridge if needed. |
| Windows Forms Legacy Controls | 8 | 4,1% | Legacy Windows Forms controls that have been removed from .NET Core/5+ including StatusBar, DataGrid, ContextMenu, MainMenu, MenuItem, and ToolBar. These controls were replaced by more modern alternatives. Use ToolStrip, MenuStrip, ContextMenuStrip, and DataGridView instead. |
| Windows Forms | 176 | 89,8% | Windows Forms APIs for building Windows desktop applications with traditional Forms-based UI that are available in .NET on Windows. Enable Windows Desktop support: Option 1 (Recommended): Target net9.0-windows; Option 2: Add <UseWindowsDesktop>true</UseWindowsDesktop>; Option 3 (Legacy): Use Microsoft.NET.Sdk.WindowsDesktop SDK. |

