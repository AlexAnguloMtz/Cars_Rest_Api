#!/bin/bash

# Wait before sqlserver is up and running, before creating our database and tables
sleep 200

# Login to sqlserver and create our database and tables
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P $MSSQL_SA_PASSWORD -d master -i /usr/config/setup.sql