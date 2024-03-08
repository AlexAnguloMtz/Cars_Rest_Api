#!/bin/bash

# Start database configuration in the background
/usr/config/configuration.sh &

# Start SQL Server
/opt/mssql/bin/sqlservr
echo "SQL Server started"
