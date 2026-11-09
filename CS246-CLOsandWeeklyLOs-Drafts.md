<h1>CS246 System Design: Draft CLOs and Weekly LOs</h1>

**Draft, November 2026**

[TOC]

## Current Catalog CLOs

Upon successful completion of this course, the student will be able to:

1. Explain what is meant by software engineering and why it is valued
2. Discuss the differences between peer-to-peer and server based version control systems and give an example of each
3. Demonstrate the use of an issue tracking system
4. Explain the advantages and disadvantages of waterfall and agile development paradigms
5. Create effective system design documentation

## Proposed CLOs

Upon successful completion of this course, the student will be able to:

1. **Identify a client's needs and turn them into requirements.** Assess needs through interviews, surveys and observation, and write a requirements document that covers stakeholders, functional and non-functional requirements, constraints and acceptance criteria.
2. **Plan and manage a software project with agile methods.** Describe the SDLC, compare waterfall with agile (Scrum and Kanban), write epics and user stories, and keep a product backlog in an issue tracking system such as Jira.
3. **Design, test and refine a user experience.** Apply user-centered design and universal access, create user flows, sitemaps and wireframes, run usability tests, and revise the design based on feedback from users and the client.
4. **Model an object-oriented system.** Analyze a problem description, model the solution with UML class diagrams and a domain model, and implement the classes and their relationships in code.
5. **Explain and apply design patterns.** This covers Gang of Four patterns and architectural patterns (layered, MVC, repository), including the ones built into .NET/ASP.NET.
6. **Use prototyping to reduce project risk.** Choose among throwaway, evolutionary, incremental and extreme prototypes, and build a throwaway prototype to test a technical challenge.
7. **Work professionally on a team for a real client.** Set team norms in a team contract, use collaboration tools (Jira, Git/GitHub, Discord), write a contract with the client, and present a system design to stakeholders.

### How the catalog CLOs map to the proposed CLOs

| Catalog CLO | Proposed CLO |
| --- | --- |
| 1. Explain software engineering and why it is valued | Folded into CLOs 1, 2 and 7 |
| 2. Peer-to-peer vs. server based version control | Dropped as a topic. Git/GitHub use is kept in CLO 7 |
| 3. Use an issue tracking system | CLO 2 |
| 4. Waterfall vs. agile | CLO 2 |
| 5. Create system design documentation | CLOs 1, 3, 4 and 7 |

## Weekly LOs

W01–W05 LOs were inferred from the lecture notes. W06–W10 LOs come from the "Objectives" sections of the weekly overviews.

### Week 1: Problem Solving, Requirements, SDLC

*CLOs 1, 2, 3*

- Explain that software is written to meet a real need, and that "problem" here means a need, not something broken.
- Identify needs (slow or error-prone processes, poor communication, hard-to-reach data) and propose solutions: copy an existing solution, automate a manual one, or invent a new one.
- Describe ways to assess needs: interviews, surveys, observing the work, job shadowing.
- List the parts of a requirements document: purpose and scope, stakeholders, functional and non-functional requirements, constraints, assumptions, data, interfaces, risks, acceptance criteria.
- Describe the five SDLC phases: planning, analysis, design, implementation, maintenance.
- Compare the waterfall and agile processes, and describe Scrum and Kanban.
- Choose a UX wireframing tool (Balsamiq or Figma) and get familiar with it.

### Week 2: Agile Project Management

*CLO 2*

- Explain how agile development and agile project management work.
- Create a Scrum project in Jira and add team members to it.
- Write user stories in the role / action / benefit format and group them into epics.
- Represent user roles and permissions either as user stories or as non-functional requirements.
- Explain how initiatives group epics in larger projects.

### Week 3: UX Design and Testing

*CLO 3*

- Define UX and user-centered design, including universal access (accessibility, slow connections, older devices).
- Describe what UX designers do: user flows, UI design patterns, personas, content inventories, style guides.
- Create wireframes and mock-ups, and tell low-fidelity designs apart from high-fidelity ones.
- Tell usability testing apart from functional testing.
- Plan and run a usability test: test script, testers or focus groups, observers, a debriefing, and a short list of the most important fixes.
- Describe ways to get user feedback: surveys, interviews, recordings, A/B testing, instrumented code.

### Week 4: OO Design with UML

*CLO 4*

- Tell libraries, frameworks and custom code apart, and decide when custom design is needed.
- Review OOP terms: class, object, field, method, static class.
- Find candidate classes, fields and methods in a written problem description by looking at its nouns and verbs.
- Model classes and their relationships in a UML class diagram: access modifiers, association, aggregation, composition, inheritance, cardinality.
- Implement inheritance, composition and aggregation in C#.
- Use a UML tool such as UMLet or Mermaid.
- Explain why design skills matter more now that AI writes more of the code.

### Week 5: Real Project, Requirements and Teamwork

*CLOs 1, 7*

- Describe the goals of good teamwork: fair split of the work, decisions made together, conflicts resolved, reliability, respect.
- Write a team contract that covers procedures, accountability, participation and tracking hours.
- Interview a real client (taking notes or recording, with permission) and write a requirements document.
- Describe the requirements roles in larger companies: business analyst, systems analyst, architect, developer.
- Tell business requirements apart from software requirements (SRS).

### Week 6: Real Project, UX Design

*CLO 3*

- Decide what web pages the client's site needs and make a sitemap.
- Design wireframe diagrams for all the web pages.
- Test the UX design and get feedback from the client and/or potential users of the site.
- Revise the UX design based on the feedback.

### Week 7: Real Project, Epics and User Stories

*CLO 2*

- Start a new Jira project for the client's site.
- Create a product backlog of epics and user stories.
- Get feedback from the client on the backlog.

### Week 8: Design Patterns

*CLO 5*

- Understand what design patterns are and how they are used.
- Know in general what the "Gang of Four" design patterns are.
- Be able to identify a few common design patterns.
- Be able to discuss design patterns that are "baked into" .NET and ASP.NET.
- Be able to discuss the implementation of some common design patterns in C#.
- Describe architectural patterns (layered, MVC, repository), and tell formal patterns apart from informal ones. *(From the design patterns lecture notes, which are filed under W04.)*

### Week 9: Real Project, Prototyping

*CLOs 4, 6*

- Understand what prototypes are and how they are used.
- Know four types of prototypes: throwaway, evolutionary, incremental and extreme.
- Be able to use a throwaway prototype to test technical challenges.

### Week 10: Real Project, Domain Model and Client Contract

*CLOs 4, 7*

- Build a domain model and revise the scaffolded CRUD code to handle properties that are other domain model classes (Lab 9).
- Write a contract between the team and the client.
- Prepare for the design presentations.

### Week 11: Design Presentations

*CLO 7*

- Present the system design to stakeholders.

## Things to Fix in the Course Materials

- **W03 overview:** The title says "Week 2", and the Objectives section is a copy of W02's agile/Jira text instead of UX design.
- **W02–W05 overviews:** They have no objectives that match their topics. The W01–W05 LOs above could fill those sections.
- **Design patterns lecture:** It is filed under W04, but the topic table puts design patterns in Week 8.
- **Topic tables:**
  - Async unit testing (W09) isn't listed.
  - The W09 overview calls Week 10 "Test Domain Models and Client Contract", but the other weeks call it "Client Contract".
