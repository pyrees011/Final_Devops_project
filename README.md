**FINAL_DEVOPS_PROJECT (v1.1.0)**

## **Project Overview**
This project showcases a full-stack application built with **Rust** (backend) and **Blazor** (frontend), incorporating modern DevOps practices. The application is designed to meet requirements such as Dockerization, Semantic Versioning, GitHub Flow, Unit Testing, and CI/CD workflows.

---

## **Releases**
### **v1.1.0 (2024-12-24)**
#### **Bug Fixes**
- Implemented the use of SSH keys for `npm` to ensure secure access to the package registry (commit: `45b8ed1`).
- Resolved issues in the workflow for publishing to the npm registry (commit: `e80615e`).
- Adjusted npm registry settings in CI/CD workflows for enhanced functionality (commit: `9dd840d`).

#### **Features**
- Added `.npmrc` configuration file to enable seamless package publishing to npm (commit: `aa02355`).

**Assets:**
- [Source code (zip)](link-to-asset)
- [Source code (tar.gz)](link-to-asset)

---

### **v1.0.0 (2024-12-23)**
#### **Bug Fixes**
- Resolved a bug in the `/tony` route by adding an embedded video (commit: `6685cd5`).
- Addressed missing library dependencies, ensuring a functional build (commit: `f543392`).

#### **Features**
- Implemented foundational routes `/` and `/greet` (commit: `ae9ad52`).
- Added a custom `/tony` route (commit: `ac2d09f`).
- Built and integrated the Blazor frontend application with its respective routes (commit: `5633c85`).

**Assets:**
- [Source code (zip)](link-to-asset)
- [Source code (tar.gz)](link-to-asset)

---

## **Changelog**
This section tracks the history of changes made to the project:

### **1.1.0 (2024-12-24)**
- **Enhancements**: `.npmrc` configuration, improved npm registry settings.
- **Fixes**: Secure `npm` access, streamlined workflows.

### **1.0.0 (2024-12-23)**
- **New Features**: Initial routes and frontend application.
- **Fixes**: Bugs in routes and missing libraries.

---

## **Versioning and GitHub Actions**
Semantic Versioning (SemVer) has been adhered to, ensuring clarity and consistency:
- **v1.0.0**: Major features implemented, marking the initial release.
- **v1.1.0**: Introduced features for publishing to npm and resolved critical bugs.

GitHub Actions have been used for automating:
- **Testing**: Backend and frontend test cases.
- **Linting**: Ensuring code quality.
- **Building**: Docker images for deployment.
- **Releasing**: Automated tagging and release creation.

---

## **Setup & Contribution Workflow**

### **Local Setup**
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/pyrees011/final_devops_project.git
   cd final_devops_project
   ```

2. **Build the Application**:
   ```bash
   docker-compose up --build
   ```

3. **Test Locally**:
   - Backend:
     ```bash
     cargo test
     ```
   - Frontend:
     ```bash
     dotnet test TestProject
     ```

### **Contributing**
1. **Create a Feature Branch**:
   ```bash
   git checkout -b feature/your-feature-name
   ```

2. **Commit Changes**:
   Follow the repository’s commit message convention for clear tracking.

3. **Submit a Pull Request**:
   Open a PR for review and merge into `main`.

---

## **Future Roadmap**
1. Add integration tests for end-to-end testing.
2. Optimize Docker images for faster builds.
3. Expand frontend routes for enhanced functionality.
4. Deploy the app to a cloud environment (e.g., AWS or Azure).

---

## **License**
This project is licensed under the ISC License.
