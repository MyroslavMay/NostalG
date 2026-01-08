# NostalG .NET net10.0-windows Upgrade Tasks

## Overview

This document tracks the atomic upgrade of the `NostalG` WinForms project from .NET Framework (`net48`) to `net10.0-windows`. The upgrade converts `NostalG.csproj` to SDK-style, updates project settings and packages, fixes compilation-breaking API changes in a single coordinated operation, and performs automated validation.

**Progress**: 1/3 tasks complete (33%) ![0%](https://progress-bar.xyz/33)

---

## Tasks

### [✓] TASK-001: Verify prerequisites *(Completed: 2026-01-08 14:13)*
**References**: Plan §Project-by-Project Plans (Prerequisites), Plan §Migration Strategy

- [✓] (1) Verify .NET 10 SDK is installed per Plan §Project-by-Project Plans (use `dotnet --list-sdks`)
- [✓] (2) Runtime/SDK version meets minimum requirements (**Verify**)
- [✓] (3) Update or add `global.json` to pin .NET 10 SDK if present/recommended per Plan §Project-by-Project Plans
- [✓] (4) Verify tooling supports .NET 10 and Windows desktop workloads (IDE/CLI/workload presence) per Plan §Migration Strategy (**Verify**)

### [▶] TASK-002: Atomic project conversion, framework/package updates, and compilation fixes
**References**: Plan §Project-by-Project Plans, Plan §Migration Strategy, Plan §Package Update Reference, Plan §Breaking Changes Catalog

- [✓] (1) Convert `NostalG.csproj` to SDK-style targeting `net10.0-windows` and enable WinForms (`<UseWindowsForms>true</UseWindowsForms>`) per Plan §Project-by-Project Plans
- [✓] (2) Apply required project property updates and add any interim package references if needed (e.g., `System.Configuration.ConfigurationManager`, `System.Drawing.Common`) per Plan §Package Update Reference
- [✓] (3) Preserve/ensure inclusion of resources and designer/embedded files as required by Plan §Project-by-Project Plans (adjust project items in `.csproj`)
- [▶] (4) Restore dependencies (`dotnet restore`) per Plan §Project-by-Project Plans
- [▶] (5) Build the solution and fix all compilation errors caused by the framework/package upgrade using guidance in Plan §Breaking Changes Catalog (single bounded pass: build + fix)
- [ ] (6) Solution builds with 0 errors (**Verify**)  
- [ ] (7) Commit changes with message: "TASK-002: Atomic upgrade to net10.0-windows (convert project, update packages, fix compilation)"

### [ ] TASK-003: Run automated validation and fix issues
**References**: Plan §Testing & Validation Strategy, Plan §Success Criteria

- [ ] (1) Run any test projects (if present) using `dotnet test` per Plan §Testing & Validation Strategy  
- [ ] (2) Fix any test failures (reference Plan §Breaking Changes Catalog for common issues)  
- [ ] (3) Re-run tests after fixes per Plan §Testing & Validation Strategy  
- [ ] (4) All tests pass with 0 failures (**Verify**)






