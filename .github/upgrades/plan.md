# .github/upgrades/plan.md

## Table of Contents

- [Executive Summary](#executive-summary)
- [Migration Strategy](#migration-strategy)
- [Detailed Dependency Analysis](#detailed-dependency-analysis)
- [Project-by-Project Plans](#project-by-project-plans)
- [Package Update Reference](#package-update-reference)
- [Breaking Changes Catalog](#breaking-changes-catalog)
- [Testing & Validation Strategy](#testing--validation-strategy)
- [Risk Management](#risk-management)
- [Complexity & Effort Assessment](#complexity--effort-assessment)
- [Source Control Strategy](#source-control-strategy)
- [Success Criteria](#success-criteria)

---

## Executive Summary

Selected Strategy

**All-At-Once Strategy** - All projects upgraded simultaneously in a single atomic operation.

Rationale

- Solution size: 1 project (Classic WinForms) — small solution suitable for an all-at-once upgrade.
- Current target: `net48` ? Proposed: `net10.0-windows` (assessment recommends Windows-specific target to enable WinForms support).
- Key findings from assessment: Project is classic (non-SDK) WinForms; requires conversion to SDK-style; many Windows Forms and System.Drawing API incompatibilities (176 binary incompatible, 20 source incompatible); estimated ~196+ LOC to modify (~39% of codebase).
- No NuGet packages reported; no security vulnerabilities flagged by analysis.

Scope

- Project: `NostalG.csproj` (path: `D:\NostalG\NostalG.csproj`).
- Files with incidents (examples): `Background.cs`, `CustomControls\DefaultProgramBar.cs`, `CustomControls\DefaultProgramBar.Designer.cs`, `ProgramManager.cs`, `ProgramManager.Designer.cs`.

Deliverable

A single coordinated upgrade that converts the project to SDK-style, updates the target framework to `net10.0-windows`, applies necessary code fixes for API incompatibilities, and produces a buildable solution with no compilation errors.


## Migration Strategy

Approach

- Use the All-At-Once approach: perform a single atomic upgrade operation that updates project(s) and package references, restores dependencies, builds the solution, and fixes compilation issues in one bounded pass.
- Rationale: one small solution, local desktop app, and clear set of Windows-desktop-specific changes make an atomic upgrade practical.

High-level phases (conceptual, not per-project tasks)

- Phase 0: Prerequisites — SDK installation, branch preparation (branch already created: `upgrade-to-net10`), handle pending changes.
- Phase 1: Atomic Upgrade (single operation)
  - Convert `NostalG.csproj` to SDK-style (Windows desktop SDK variant)
  - Update target framework(s) to `net10.0-windows`
  - Update project file properties (<UseWindowsForms> or SDK attribute)
  - Restore dependencies and build solution
  - Fix compilation errors caused by framework/API changes
- Phase 2: Test & Validation
  - Execute automated tests (none discovered) and run smoke verification steps
  - Address runtime/behavioral regressions

Notes about All-At-Once

- This plan requires coordinated execution and a single atomic commit containing all project file and package updates plus compilation fixes.
- Expect a single pass of changes: update project(s) ? update packages ? restore ? build + fix ? verify.


## Detailed Dependency Analysis

Summary

- Total projects: 1 (`NostalG.csproj`).
- No project-to-project dependencies. The single project is effectively a leaf and root.
- Because there are no dependent projects, the migration scope is limited to the one project but includes many API compatibility fixes inside the code.

Implications

- No cross-project ordering constraints apply — the single project will be upgraded as part of the atomic operation.
- Test projects (none discovered) would normally be migrated after the main project.


## Project-by-Project Plans

### Project: `NostalG.csproj`

Current state

- Path: `D:\NostalG\NostalG.csproj`
- Current Target Framework: `net48`
- SDK-style: No (classic project)
- Project type: WinForms (ClassicWinForms)
- Files: 14; Files with incidents: 9
- LOC: ~500; estimated LOC to modify: 196+

Target state

- Target Framework: `net10.0-windows`
- SDK-style: Yes — using `Microsoft.NET.Sdk.WindowsDesktop` or SDK `Microsoft.NET.Sdk` with `<UseWindowsForms>true</UseWindowsForms>`
- Project builds cleanly under .NET 10 and Windows desktop workloads

Migration steps (what to do, executor must perform these in the atomic upgrade task)

1. Prerequisites (local environment)
   - Ensure .NET 10 SDK is installed on all developer/CI machines. Validate with `dotnet --list-sdks`.
   - If `global.json` exists, update or add it to pin to the .NET 10 SDK (optional but recommended).
   - Ensure Visual Studio / tooling supports .NET 10 and Windows desktop workloads.

2. Convert project file to SDK-style and enable WinForms
   - Replace the classic project MSBuild file with an SDK-style .csproj. Suggested minimal SDK-style template:

```xml
<Project Sdk="Microsoft.NET.Sdk.WindowsDesktop">
  <PropertyGroup>
    <TargetFramework>net10.0-windows</TargetFramework>
    <UseWindowsForms>true</UseWindowsForms>
    <ImplicitUsings>disable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>
  <!-- Preserve resources and embedded files as needed -->
</Project>
```

   - Alternative: use `Sdk="Microsoft.NET.Sdk"` and set `<UseWindowsForms>true</UseWindowsForms>`; using `Microsoft.NET.Sdk.WindowsDesktop` is explicit and recommended for desktop apps.
   - Ensure embedded resources (.resx) and designer-generated files remain included (verify `Compile` and `EmbeddedResource` item groups if needed).

3. Remove/replace legacy project settings
   - Remove `<supportedRuntime>` entries from `App.config` (these are .NET Framework runtime directives). Document and keep a backup of original `App.config`.
   - If the app relies on `app.config` keys, add `System.Configuration.ConfigurationManager` NuGet package and keep `app.config` until migrating to `Microsoft.Extensions.Configuration`.

4. Update code to address API incompatibilities
   - Review and fix occurrences of Windows Forms APIs flagged by the assessment (examples: `AutoScaleMode`, `Control.Name`, `DockStyle`, `FormBorderStyle`, `Control.Size`, `SuspendLayout/ResumeLayout`, legacy `Menu`/`MenuItem` usage).
   - Update usages of System.Drawing constructors or types that changed; replace where appropriate or add `System.Drawing.Common` package if acceptable for Windows-only apps.
   - Replace legacy controls (e.g., `MainMenu`, `MenuItem`, `StatusBar`, `ToolBar`) with supported alternatives (`MenuStrip`, `ContextMenuStrip`, `ToolStrip`, `StatusStrip`) where feasible.
   - Fix binary-incompatible API sites by refactoring code to use the supported APIs. Use compiler diagnostics as the authoritative source of required edits.

5. Rebuild and fix compilation errors
   - Restore packages (`dotnet restore`), build solution (`dotnet build`), and iterate on fixing all compiler errors uncovered by the new target.
   - Treat this as part of the atomic operation: update project files and code until the solution builds with 0 errors.

6. Resource and Designer adjustments
   - Open designer-generated files in Visual Studio and re-save forms if designers require regenerated code. Address any .Designer.cs changes required by new WinForms implementation.

7. Configuration and runtime testing
   - If configuration keys are required, maintain `app.config` via `System.Configuration.ConfigurationManager` until a migration to `Microsoft.Extensions.Configuration` is completed.

Validation for this project

- Project converted to SDK-style and committed in the atomic upgrade.
- TargetFramework changed to `net10.0-windows`.
- Solution restores and builds with 0 errors.
- No outstanding compilation warnings that block migration (warnings should be reviewed but do not block completion unless critical).

Files to review/expect changes

- `NostalG.csproj` — converted to SDK-style
- `App.config` — review and remove `<supportedRuntime>` entry; keep/convert configuration usage
- `Background.cs`, `CustomControls\DefaultProgramBar.cs`, `CustomControls\DefaultProgramBar.Designer.cs`, `ProgramManager.cs`, `ProgramManager.Designer.cs` — likely require code updates per API incompatibilities


## Package Update Reference

- Assessment found no NuGet packages requiring upgrade. If during code fixes you introduce `System.Configuration.ConfigurationManager` or `System.Drawing.Common`, list them here with exact versions used.


## Breaking Changes Catalog

Top Windows Forms and System.Drawing categories to expect (non-exhaustive)

- Controls and properties that changed or were removed: legacy `Menu`/`MainMenu`/`MenuItem` family, `StatusBar`, `ToolBar`.
- Layout and scaling: `AutoScaleMode` and `AutoScaleDimensions` behavior may differ; review form scaling code.
- Designer differences: `.Designer.cs` code may need manual adjustments after re-saving forms in Visual Studio targeting .NET 10.
- System.Drawing: some constructors and enums (GraphicsUnit, FontStyle, Font) may have different overloads or behaviors — replace or adapt constructors accordingly.
- app.config / supportedRuntime: runtime startup directives are not applicable; configuration access patterns change — consider `System.Configuration.ConfigurationManager` as interim.

For each compilation error, use the compiler message as the primary source of required change. Log and catalog each change during the atomic upgrade.


## Testing & Validation Strategy

Automated checks

- Build verification: `dotnet restore` and `dotnet build` must succeed for the solution.
- Unit tests: none discovered; if unit tests are added/revealed, run them after the atomic upgrade.

Validation checkpoints (post-upgrade)

- Application starts successfully on Windows machine and main UI windows load.
- Core user flows relevant to the open files (program manager UI, custom program bar, background rendering) function without runtime exceptions.
- No critical runtime exceptions are observed in logs.

Note: Manual UI verification is outside automation scope but should be performed by maintainers after upgrade. The plan documents required automated validations; manual smoke checks are recommended and should be performed separately.


## Risk Management

Risk summary

- Primary risk: High number of binary-incompatible Windows Forms APIs (176) — significant code changes required.
- Secondary risk: Designer-generated files may not migrate cleanly and may require manual rework.
- Tertiary risk: System.Drawing usage and legacy configuration usage may require package additions or code refactors.

Mitigations

- Keep a backup branch and make the entire upgrade in `upgrade-to-net10` branch. Use a single atomic commit for the upgrade changes so rolling back is straightforward.
- Make small, well-scoped code changes guided by compiler diagnostics; where designer changes are needed, prefer opening forms in Visual Studio and re-saving to regenerate designer code.
- Use `System.Configuration.ConfigurationManager` as an interim compatibility bridge for `app.config` access before migrating to `Microsoft.Extensions.Configuration`.
- Run the atomic upgrade in an environment with the .NET 10 SDK and Windows desktop tooling installed.

Contingency

- If critical blocking issues arise (unresolvable API incompatibility), revert the branch or create a hotfix branch from `master` and re-assess a staged/incremental migration.


## Complexity & Effort Assessment

- Solution classification: Simple?Medium (single project but many API incompatibilities).
- Project complexity: Medium — WinForms UI code with designer artifacts and System.Drawing usage.
- Estimated LOC to modify: 196+ (from assessment). Use relative complexity ratings (Low/Medium/High) rather than time estimates.

Per-area complexity

- Project conversion (SDK-style): Low
- Designer and resource fixes: Medium
- API incompatibility fixes (Windows Forms / System.Drawing): Medium?High depending on control usage


## Source Control Strategy

- Branch: `upgrade-to-net10` (already created and active).
- Commit approach: Single atomic commit containing:
  - Converted project file(s)
  - TargetFramework updates
  - Package additions (if needed)
  - Code changes required to compile under `net10.0-windows`
- Pull request: Create a PR from `upgrade-to-net10` to `master` with a clear description, link to this plan and the assessment, and request code review.
- Review checklist (PR): build passes, no unresolved TODOs related to migration, tests pass (if any), smoke verification performed.


## Success Criteria

The migration is complete when all of the following are true:

1. `NostalG.csproj` is converted to SDK-style and targets `net10.0-windows`.
2. All package additions/updates from the migration are present in the project file with exact versions recorded in `plan.md`.
3. `dotnet restore` and `dotnet build` succeed with 0 errors for the solution.
4. No remaining security vulnerabilities introduced by dependency changes.
5. Manual smoke validation confirms main UI loads and core flows are functional (documented in PR).
6. A PR exists from `upgrade-to-net10` to `master` with reviewer approval.


---

Appendix: Helpful snippets

- Example minimal SDK-style WinForms project header

```xml
<Project Sdk="Microsoft.NET.Sdk.WindowsDesktop">
  <PropertyGroup>
    <TargetFramework>net10.0-windows</TargetFramework>
    <UseWindowsForms>true</UseWindowsForms>
  </PropertyGroup>
</Project>
```

- If `app.config` is used for configuration access, add interim package (replace X.Y.Z with chosen version):

```xml
<PackageReference Include="System.Configuration.ConfigurationManager" Version="7.0.0" />
