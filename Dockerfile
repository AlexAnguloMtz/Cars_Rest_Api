FROM mcr.microsoft.com/mssql/server:latest
COPY setup.sql .
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=Tacodemanzana1!
RUN /opt/mssql/bin/sqlservr & sleep 60 && /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Tacodemanzana1! -i setup.sql