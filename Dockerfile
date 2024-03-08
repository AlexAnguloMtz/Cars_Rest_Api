FROM mcr.microsoft.com/mssql/server:2022-latest

# Create a config directory
USER root
RUN mkdir -p /usr/config
WORKDIR /usr/config

# Copy scripts
COPY ./scripts/setup.sql .
COPY ./scripts/entrypoint.sh .
COPY ./scripts/configuration.sh .

RUN chmod +x /usr/config/entrypoint.sh
RUN chmod +x /usr/config/configuration.sh

#Set the entrypoint script
ENTRYPOINT ["/bin/bash", "/usr/config/entrypoint.sh"]


