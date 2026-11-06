# ControlAccess

A Chilean license plate rolls up, the camera reads it, and the barrier gets a yes or a no — the first real app Nicolas Wozniak shipped, in his second year of university.

A condominium gate in Chile still meant a person in a booth with a list. He wanted the booth to read the plate itself. Nothing like that was around for him to copy, so he built ControlAccess alone: a one-person observation post for the gate, made with Google, Stack Overflow, and a camera.

The desk is small on purpose. You log in, hand it a plate image, and Spanish OCR pulls the characters. SQL Server checks the resident’s plates and any guest invitation. A known plate marks the barrier open. An unknown one stays closed, and the arrival can be written down with the time. Each resident holds up to three plates and can register three invitation plates for visitors.

What is worth keeping is the craft. In his second year he learned computer vision and access control at the same time, by himself, and kept tuning the reader until Chilean plates came through cleanly. Around that sit the pieces a gatehouse actually uses: users, invitations, an admin report, and a clear open or closed.

## Highlights

- Spanish OCR on the camera image, matched to resident and guest plates
- Known plate marks the barrier open; an unknown plate stays closed and can be logged
- Three plates per resident, plus three invitation plates
- Login, user CRUD, admin view, camera status, and database status
- Resident report in RDLC

**Stack:** C# · WinForms · .NET Framework 4.5.2 · SQL Server · typed DataSets · MODI OCR (Spanish) · RDLC

**Status:** University project, second year (2016). Early-career work, public repo. His first real app.

**Author:** Nicolas Wozniak, Chile — solo developer. TECHNOLOGIES SOLUTIONS CARLOS NICOLAS CONCHA WOZNIAK E.I.R.L. / W.Enterprise.

---

# ControlAccess

Llega una patente chilena, la cámara la lee, y el pórtico recibe un sí o un no — la primera aplicación de verdad de Nicolas Wozniak, en segundo año de universidad.

La barrera de un condominio en Chile seguía siendo una persona en la caseta con una lista. Él quería que la caseta leyera la patente sola. No había nada parecido a la mano, así que armó ControlAccess solo: una caseta de observación para el portón, hecha con Google, Stack Overflow y una cámara.

La pantalla es chica a propósito. Entras con login, le pasas la imagen de la patente, y un OCR en español saca los caracteres. SQL Server revisa las patentes del residente y las de invitación. Si calza, el pórtico queda marcado abierto. Si no, sigue cerrado, y la llegada se puede anotar con la hora. Cada residente tiene hasta tres patentes y puede registrar tres patentes de invitación para las visitas.

Lo que vale la pena guardar es el oficio. En segundo año aprendió visión por computador y control de acceso al mismo tiempo, solo, y fue ajustando el lector hasta que las patentes chilenas salían nítidas. Alrededor están las piezas que una caseta de verdad usa: usuarios, invitaciones, un reporte de administración, y un abierto o cerrado claro.

## Destacados

- OCR en español sobre la imagen de la cámara, cruzado con patentes de residentes e invitados
- Patente conocida marca el pórtico abierto; una desconocida lo deja cerrado y se puede registrar
- Tres patentes por residente, más tres de invitación
- Login, CRUD de usuarios, vista de administración, estado de cámara y de la base de datos
- Reporte de residentes en RDLC

**Stack:** C# · WinForms · .NET Framework 4.5.2 · SQL Server · DataSets tipados · MODI OCR (español) · RDLC

**Estado:** Proyecto universitario, segundo año (2016). Trabajo de inicios de carrera, repositorio público. Su primera app de verdad.

**Autor:** Nicolas Wozniak, Chile — desarrollador en solitario. TECHNOLOGIES SOLUTIONS CARLOS NICOLAS CONCHA WOZNIAK E.I.R.L. / W.Enterprise.
