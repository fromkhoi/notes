#region write log method

        /// <summary>
        /// Write log start.
        /// </summary>
        private void StartLog(string nameLog)
        {
            this._logger.LogDebug("--------------------------------------------------------------------------------------------------------------------------------------");
            this._logger.LogDebug($"{DateTime.Now.ToString()}");
            this._logger.LogDebug($"■ Start {nameLog} of OrderWorkerService");
            this._logger.LogDebug("--------------------------------------------------------------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Write log end.
        /// </summary>
        private void EndLog(string nameLog)
        {
            this._logger.LogDebug(" ");
            this._logger.LogDebug($"{DateTime.Now.ToString()}");
            this._logger.LogDebug($"■ End {nameLog} of OrderWorkerService");
            this._logger.LogDebug("--------------------------------------------------------------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Write log request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <param name="detail"></param>
        private void WriteLogRequest<T>(T request, string detail)
        {
            this._logger.LogDebug(" ");
            this._logger.LogDebug($"{DateTime.Now.ToString()}");
            this._logger.LogDebug($"■ {detail}");
            this._logger.LogDebug(" ");

            this._logger.LogDebug($"[Request Parameter]");

            try
            {
                this._logger.LogDebug(JsonConvert.SerializeObject(request, Formatting.Indented));
                this._logger.LogDebug(" ");
            }
            catch (Exception ex)
            {
                this._logger.LogError(ex.ToString());
            }

            this._logger.LogDebug($"■ 処理開始：{DateTime.Now.ToString("HH:mm:ss")}");
            this._logger.LogDebug("--------------------------------------------------------------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Write Log
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <param name="detail"></param>
        private void WriteLog<T>(T request, string detail)
        {
            this._logger.LogDebug(" ");
            this._logger.LogDebug($"{DateTime.Now.ToString()}");
            this._logger.LogDebug($"■ {detail}");

            try
            {
                this._logger.LogDebug(" ");
                this._logger.LogDebug(JsonConvert.SerializeObject(request, Formatting.Indented));
                this._logger.LogDebug(" ");
            }
            catch (Exception ex)
            {
                this._logger.LogError(ex.ToString());
            }
            this._logger.LogDebug("--------------------------------------------------------------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Write Response Log
        /// </summary>
        /// <param name="response"></param>
        private void WriteLogResponse<T>(T response)
        {
            this._logger.LogDebug(" ");
            this._logger.LogDebug($"■ 処理終了: {DateTime.Now.ToString("HH:mm:ss")}");
            this._logger.LogDebug($"[Response]");

            try
            {
                this._logger.LogDebug(JsonConvert.SerializeObject(response, Formatting.Indented));
                this._logger.LogDebug(" ");
            }
            catch (Exception ex)
            {
                this._logger.LogError(ex.ToString());
            }
            this._logger.LogDebug("--------------------------------------------------------------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Write Exception Log
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response"></param>
        /// <param name="detail"></param>
        private void HandleExceptionLog<T>(T response, string detail = "")
        {
            this._logger.LogDebug($"{detail}");
            this._logger.LogDebug($"[Exception Error]");

            try
            {
                this._logger.LogDebug(JsonConvert.SerializeObject(response, Formatting.Indented));
                this._logger.LogDebug(" ");
            }
            catch (Exception ex)
            {
                this._logger.LogError(ex.ToString());
            }
            this._logger.LogDebug("--------------------------------------------------------------------------------------------------------------------------------------");
        }
        #endregion